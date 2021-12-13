using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace boki
{
    class Operation1
    {
        // ランダムで問題No.を決定
        public int GetQuestionNum(string csvFilePass)
        {
            int rNum;                                   // ランダムで取得した仮の問題No.を格納する変数
            int seed;                                   // ランダムの種を格納する変数
            seed = Environment.TickCount;               // seed にランダムの種を格納
            Random rnd = new Random(seed);              // Randomクラス rnd のインスタンスを宣言
            using(TextFieldParser tfp = new TextFieldParser(csvFilePass))
            {
                int qCount = 0;                             // csvファイル内の問題数を格納するための変数
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");                     // 区切り文字はがカンマであることを宣言
                tfp.HasFieldsEnclosedInQuotes = true;       // 列が「""」で囲われていることを宣言
                tfp.TrimWhiteSpace = false;
                // csvファイル内の問題数をカウント
                while (!tfp.EndOfData)
                {
                    tfp.ReadFields();
                    qCount++;
                }
                rNum = rnd.Next(1, qCount);                 // 仮の問題No.をランダムで設定し rNum に格納
            }
            return rNum;
        }

        // csvファイルから任意の行(qNum)を取り出し、string型の配列に各列のデータを格納
        public void GetCsvLine(ref string[] qStr, int qNum, string filePass)
        {
            TextFieldParser tfp = new TextFieldParser(filePass);

            using (tfp)
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");
                // フィールドが引用符("")で囲まれているか
                tfp.HasFieldsEnclosedInQuotes = true;
                // フィールドのトリム設定
                tfp.TrimWhiteSpace = false;
                // 指定問題番号「qNum」までループ
                for (int i = 0; i <= qNum; i++)
                {
                    tfp.ReadFields();                   // 指定行の1行前まで行を読み込む
                    if (i + 1 == qNum)                  // 指定行か判定(0行目は見出し行なので指定行は「i + 1」)
                    {
                        qStr = tfp.ReadFields();        // 指定行のデータを列ごとに分割して配列に格納
                    }
                }
            }
        }

        // 正答の項目数をカウント
        public void QuestionCount(string q1, string q2, string q3, ref int qCount)
        {
            string[] q = { q1, q2, q3 };        // 正解を配列に格納
            for (int i = 0; i < 3; i++)
            {
                if (q[i] == "")                 // 空欄を判定
                {
                    qCount--;                   // 空欄の場合は項目数を1減らす
                }
            }
        }

        // 解答の正否を判定し、正解ならtrue、不正解ならfalseを返す
        public bool CheckAnswer(ComboBox cBox, TextBox tBox, string[] qStr, ref int aCount, int box1Num)
        {
            bool judg = false;                  // 正否判定用の変数(正解 = true)
            if (cBox.Text == "")
            {
                aCount--;                       // 解答欄が空欄の場合、回答数を1減らす
            }
            // コンボボックスの解答が正解の中にあるか検索(借方、貸方、各項目の1番目を基準に配列 qStr を指定)
            if (cBox.Text == qStr[box1Num] || cBox.Text == qStr[box1Num + 4] || cBox.Text == qStr[box1Num + 8])
            {
                for (int i = box1Num; i <= box1Num + 8; i = i + 4)
                {
                    if (cBox.Text == qStr[i])               // 配列 qStr で解答(cBox) と合致する部分を検索
                    {
                        if (tBox.Text == qStr[i + 1])       // 項目が合致した部分の金額(qStr[i + 1])と解答(金額：tBox)を比較
                        {
                            judg = true;                    // 項目と金額、両方が合っている場合、judg = true
                        }
                        else
                        {
                            tBox.ForeColor = Color.Red;     // 不正解の場合、金額欄の文字色を赤に
                        }
                    }
                }
            }
            else
            {
                cBox.ForeColor = Color.Red;                 // 解答欄(項目)の内容が正解にない場合、コンボボックスの文字色を赤に
            }
            return judg;
        }

        // 解答の重複を確認、重複した場合はjudgにfalseを格納(不正解になる)
        public void CheckDuplicate(ref bool[] judg, ComboBox debBox1, ComboBox debBox2, ComboBox debBox3, ComboBox creBox1, ComboBox creBox2, ComboBox creBox3)
        {
            ComboBox[] dbBox = { debBox1, debBox2, debBox3 };                   // 借方の解答欄を配列に
            ComboBox[] crBox = { creBox1, creBox2, creBox3 };                   // 貸方の解答欄を配列に
            string[] dbText = { debBox1.Text, debBox2.Text, debBox3.Text };     // 借方の解答欄に入力した文字列を配列に
            string[] crText = { creBox1.Text, creBox2.Text, creBox3.Text };     // 貸方の解答欄に入力した文字列を配列に
            for(int i = 0; i < 2; i++)
            {
                if(dbText[i] != "")                             // 解答欄が空欄か判定(空欄の場合、重複から外す)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if(dbText[i] == dbText[j])              // 解答欄1と2、3の重複を確認⇒解答欄2と3の重複を確認
                        {
                            judg[j] = false;                    // 重複がある場合、judg に false を格納(不正解に)
                            dbBox[i].ForeColor = Color.Red;     // 解答欄[i]の文字色を赤に
                            dbBox[j].ForeColor = Color.Red;     // 解答欄[j]の文字色を赤に
                        }
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (crText[i] != "")                            // 解答欄が空欄か判定(空欄の場合、重複から外す)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (crText[i] == crText[j])             // 解答欄1と2、3の重複を確認⇒解答欄2と3の重複を確認
                        {
                            judg[j + 3] = false;                // 重複がある場合、judg に false を格納(不正解に)
                            crBox[i].ForeColor = Color.Red;     // 解答欄[i]の文字色を赤に
                            crBox[j].ForeColor = Color.Red;     // 解答欄[j]の文字色を赤に
                        }
                    }
                }
            }
        }

        // 数字を入力すると3桁ごとにカンマを挿入
        public void CommaInsert(TextBox tb)
        {
            string debmoTemp = tb.Text.Replace(",", "");            // 金額欄に入力した文字列からカンマを削除
            long value;                                             // long型に変換した値を格納する変数
            bool success = long.TryParse(debmoTemp, out value);     // 金額欄の数字をlong型に変換(成功すれば、success = true、value に金額を代入)
            // 金額欄が空欄の場合、success に true を代入
            if (debmoTemp == "")
            {
                success = true;
            }
            // success = false のときエラーメッセージを表示、success = true かつ空欄でないとき、カンマを挿入してテキストボックスに表示
            if (!success)
            {
                MessageBox.Show("金額は半角数字で入力してください");
                tb.ForeColor = Color.Red;                           // 数字以外のときは文字色を赤に
            }
            else if (debmoTemp != "")
            {
                tb.Text = string.Format("{0:#,0}", value);          // string型に変換し⇒カンマを挿入⇒テキストボックスに代入
                tb.ForeColor = Color.Black;                         // 数字の場合は文字色を黒に
            }
        }
    }
}
