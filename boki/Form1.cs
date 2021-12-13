using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace boki
{
    public partial class Form1 : Form
    {
        int qNum;                                   // 出題番号を格納する変数
        string[] qStr = new string[21];             // 問題データ(列)を格納する配列
        string csvFilePass = "boki.csv";            // csvファイルのパス
        Operation1 op;                               // 各種操作を利用するための Operation クラス(Form1用)
        int qCount = 1;                             // 現在の出題数
        int[] qHistory = new int[5];                // 出題履歴(5件)の問題番号を格納する配列

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            op = new Operation1();                                   // 各種メソッドを格納してある Operation クラスを宣言
            qNum = op.GetQuestionNum(csvFilePass);                  // 問題No.をランダムで取得
            op.GetCsvLine(ref qStr, qNum, csvFilePass);             // 出題番号の行を取り出し、列ごとに分割して配列に格納             
            QuestionInsert(qStr);                                   // コンボボックスに選択肢のデータを追加
            qHistory[0] = qNum;                                     // 最初の問題No.を履歴の最初に記録
            questionCountBox.Text = qCount.ToString();              // 現在の出題数を表示する
        }
        // 各コントロールをフォーカス時、Enterキーを押すとコントロールをValidateする
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Validate();
            }
        }
        // 「解答」ボタンのクリックイベント
        private void AnswerButtonClicked(object sender, EventArgs e)
        {
            op = new Operation1();
            int qDebCount = 3;                  // 借方の正答の項目数(csvファイル内の正答数)
            int aDebCount = 3;                  // 借方の解答数
            int qCreCount = 3;                  // 貸方の正答の項目数(csvファイル内の正答数)
            int aCreCount = 3;                  // 貸方の解答数
            int deb1Num = 9;                    // csvファイル内の借方の項目1番目の列番号
            int cre1Num = 11;                   // csvファイル内の貸方の項目1番目の列番号
            bool[] judg = new bool[6];          // 各解答欄の正否を格納
            bool totalJudg = true;              // 問い全体の正否を格納(解答欄が1つでも間違いだと不正解)

            ColorReset();                       // 解答欄の文字色を全て黒にする
            // 解答欄の各行について正否をjudgに格納
            op.QuestionCount(qStr[deb1Num], qStr[deb1Num + 4], qStr[deb1Num + 8], ref qDebCount);   // 借方の正答の項目数を算出
            judg[0] = op.CheckAnswer(debBox1, debmoBox1, qStr, ref aDebCount, deb1Num);             // 借方1の正否を判定
            judg[1] = op.CheckAnswer(debBox2, debmoBox2, qStr, ref aDebCount, deb1Num);
            judg[2] = op.CheckAnswer(debBox3, debmoBox3, qStr, ref aDebCount, deb1Num);
            op.QuestionCount(qStr[cre1Num], qStr[cre1Num + 4], qStr[cre1Num + 8], ref qCreCount);   // 貸方の正答の項目数をカウント
            judg[3] = op.CheckAnswer(creBox1, cremoBox1, qStr, ref aCreCount, cre1Num);             // 貸方1の正否を判定
            judg[4] = op.CheckAnswer(creBox2, cremoBox2, qStr, ref aCreCount, cre1Num);
            judg[5] = op.CheckAnswer(creBox3, cremoBox3, qStr, ref aCreCount, cre1Num);
            // 解答欄の重複があった場合は該当行のjudgにfalseを格納
            op.CheckDuplicate(ref judg, debBox1, debBox2, debBox3, creBox1, creBox2, creBox3);
            // 問い全体の正否を確定(1つでも間違えば不正解)
            for(int i = 0; i < 6; i++)
            {
                if (!judg[i])
                {
                    totalJudg = false;
                }
            }
            // 判定の表示(全体の正否 = true かつ, 各項目の正解数と解答数が等しい場合 = 「正解」)
            if (totalJudg == true && qDebCount == aDebCount && qCreCount == aCreCount)
            {
                marubatuTextBox.Text = "〇正解";
                marubatuTextBox.ForeColor = Color.Green;
            }
            else
            {
                marubatuTextBox.Text = "×不正解";
                marubatuTextBox.ForeColor = Color.Red;
            }
            // 正解の表示
            AnswerShow(qStr, deb1Num, cre1Num);
        }

        // 「次の問題」ボタンのクリックイベント
        private void NextButtonClicked(object sender, EventArgs e)
        {
            BoxClear();                 // 現在表示されている項目を削除
            ColorReset();               // 現在設定されている文字色をリセット(黒に戻す)

            op = new Operation1();
            bool end = false;                              // ループを終了させるための変数(trueでループを抜ける)
            int rNum = op.GetQuestionNum(csvFilePass);     // 仮の問題No.をランダムで取得
            // 直近5問と新たな問題番号が異なれば新たな問題番号で出題
            while (!end)
            {
                bool dupli = false;             // 重複の判定結果を格納する変数(重複すると true )
                for(int i = 0; i < 5; i++)
                {
                    if(qHistory[i] == rNum)     // 直近5問と rNum が重複するか判定
                    {
                        dupli = true;
                    }
                }
                if (dupli)
                {
                    rNum = op.GetQuestionNum(csvFilePass);      // rNum が直近5門と重複した場合、仮の問題No.を再取得
                }
                else
                {
                    qNum = rNum;                                // rNum が直近5問と重複しない場合は qNum に仮の問題No.(rNum)を格納
                    qHistory[qCount % 5] = qNum;                // qHistory[] (直近5問)の一番古い問題No.に新しい問題No.を上書き
                    op.GetCsvLine(ref qStr, qNum, csvFilePass); // 問題のデータを qStr[] に格納
                    QuestionInsert(qStr);                       // 各テキストボックス、コンボボックスに問題のデータを格納
                    end = true;                                 // end に true を格納してループを抜ける
                }
            }
            qCount++;                                           // 現在の出題数に +1
            questionCountBox.Text = qCount.ToString();          // 現在の出題数を表示
        }

        // 金額欄に入力された数値にカンマを挿入
        private void DebmoBox1Validated(object sender, EventArgs e)
        {
            op = new Operation1();
            op.CommaInsert(debmoBox1);
        }

        private void DebmoBox2Validated(object sender, EventArgs e)
        {
            op = new Operation1();
            op.CommaInsert(debmoBox2);
        }

        private void DebmoBox3Validated(object sender, EventArgs e)
        {
            op = new Operation1();
            op.CommaInsert(debmoBox3);
        }

        private void CremoBox1Validated(object sender, EventArgs e)
        {
            op = new Operation1();
            op.CommaInsert(cremoBox1);
        }

        private void CremoBox2Validated(object sender, EventArgs e)
        {
            op = new Operation1();
            op.CommaInsert(cremoBox2);
        }

        private void CremoBox3Validated(object sender, EventArgs e)
        {
            op = new Operation1();
            op.CommaInsert(cremoBox3);
        }

        // 問題文を表示し、選択肢をコンボボックスに格納
        public void QuestionInsert(string[] qStr)
        {
            buntextBox.Text = "[問題No."+ qStr[0] + "]\r\n" + qStr[1];    // 問題文をテキストボックスに格納
            // 選択肢を各コンボボックスに格納
            for (int i = 2; i <= 8; i++)
            {
                debBox1.Items.Add(qStr[i]);
                debBox2.Items.Add(qStr[i]);
                debBox3.Items.Add(qStr[i]);
                creBox1.Items.Add(qStr[i]);
                creBox2.Items.Add(qStr[i]);
                creBox3.Items.Add(qStr[i]);
            }
        }

        // 正答欄に正答を表示(借方、貸方、各項目の1番目を基準に配列を指定)
        public void AnswerShow(string[] qStr, int deb1Num, int cre1Num)
        {
            adebTextBox1.Text = qStr[deb1Num];
            adebmoTextBox1.Text = qStr[deb1Num + 1];
            acreTextBox1.Text = qStr[cre1Num];
            acremoTextBox1.Text = qStr[cre1Num + 1];

            adebTextBox2.Text = qStr[deb1Num + 4];
            adebmoTextBox2.Text = qStr[deb1Num + 5];
            acreTextBox2.Text = qStr[cre1Num + 4];
            acremoTextBox2.Text = qStr[cre1Num + 5];

            adebTextBox3.Text = qStr[deb1Num + 8];
            adebmoTextBox3.Text = qStr[deb1Num + 9];
            acreTextBox3.Text = qStr[cre1Num + 8];
            acremoTextBox3.Text = qStr[cre1Num + 9];
        }

        // 解答欄の文字色を黒に戻す
        public void ColorReset()
        {
            debBox1.ForeColor = Color.Black;
            debBox2.ForeColor = Color.Black;
            debBox3.ForeColor = Color.Black;
            debmoBox1.ForeColor = Color.Black;
            debmoBox2.ForeColor = Color.Black;
            debmoBox3.ForeColor = Color.Black;
            creBox1.ForeColor = Color.Black;
            creBox2.ForeColor = Color.Black;
            creBox3.ForeColor = Color.Black;
            cremoBox1.ForeColor = Color.Black;
            cremoBox2.ForeColor = Color.Black;
            cremoBox3.ForeColor = Color.Black;
        }

        // 解答欄、正答欄のテキストを消す
        public void BoxClear()
        {
            debBox1.Items.Clear();
            debBox2.Items.Clear();
            debBox3.Items.Clear();
            creBox1.Items.Clear();
            creBox2.Items.Clear();
            creBox3.Items.Clear();
            debBox1.Text = "";
            debBox2.Text = "";
            debBox3.Text = "";
            creBox1.Text = "";
            creBox2.Text = "";
            creBox3.Text = "";
            debmoBox1.Text = "";
            debmoBox2.Text = "";
            debmoBox3.Text = "";
            cremoBox1.Text = "";
            cremoBox2.Text = "";
            cremoBox3.Text = "";
            adebmoTextBox1.Text = "";
            adebmoTextBox2.Text = "";
            adebmoTextBox3.Text = "";
            adebTextBox1.Text = "";
            adebTextBox2.Text = "";
            adebTextBox3.Text = "";
            acremoTextBox1.Text = "";
            acremoTextBox2.Text = "";
            acremoTextBox3.Text = "";
            acreTextBox1.Text = "";
            acreTextBox2.Text = "";
            acreTextBox3.Text = "";
            marubatuTextBox.Text = "";
        }

        // ×ボタンをクリックすると対応した金額欄をクリア
        private void Debmo1ClearButtonClicked(object sender, EventArgs e)
        {
            debmoBox1.Clear();
            debmoBox1.ForeColor = Color.Black;
            debmoBox1.Focus();
        }

        private void Debmo2ClearButtonClicked(object sender, EventArgs e)
        {
            debmoBox2.Clear();
            debmoBox2.ForeColor = Color.Black;
            debmoBox2.Focus();
        }

        private void Debmo3ClearButtonClicked(object sender, EventArgs e)
        {
            debmoBox3.Clear();
            debmoBox3.ForeColor = Color.Black;
            debmoBox3.Focus();
        }

        private void Cremo1ClearButtonClicked(object sender, EventArgs e)
        {
            cremoBox1.Clear();
            cremoBox1.ForeColor = Color.Black;
            cremoBox1.Focus();
        }

        private void Cremo2ClearButtonClicked(object sender, EventArgs e)
        {
            cremoBox2.Clear();
            cremoBox2.ForeColor = Color.Black;
            cremoBox2.Focus();
        }

        private void Cremo3ClearButtonClicked(object sender, EventArgs e)
        {
            cremoBox3.Clear();
            cremoBox3.ForeColor = Color.Black;
            cremoBox3.Focus();
        }
    }
}
