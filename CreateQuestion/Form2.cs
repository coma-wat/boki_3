using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Data.OleDb;

namespace CreateQuestion
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();     // csvファイルの内容を格納するデータテーブル
        string fileName = @"boki.csv";      // csvファイルのパス
        Operation2 op;                       // 各種操作を利用するための Operation クラス(Form2用)

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(",");                     // 区切り文字はがカンマであることを宣言
                tfp.HasFieldsEnclosedInQuotes = true;       // 列が「""」で囲われていることを宣言
                tfp.TrimWhiteSpace = false;

                string[] colHeaders = tfp.ReadFields();     // 見出し行を読み込み
                // 見出し行をデータテーブルに書き込み、列数を決定
                for(int i = 0; i < colHeaders.Length; i++)
                {
                    dt.Columns.Add(colHeaders[i]);
                }
                dt.Columns[0].DataType = typeof(Int32);                     // 「ID」列をint32型に変更
                dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };      // 「ID」列を主キーに設定
                // データテーブルに行(レコード)を書き込み
                while (!tfp.EndOfData)
                {
                    string[] data = tfp.ReadFields();
                    dt.Rows.Add(data);
                }
                // データテーブルのデータをデータグリッドビューに表示
                dataGridView1.DataSource = dt;
            }
        }

        // データグリッドビューの内容をCSVファイルに上書き
        private void CsvSaveButtonClicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("CSVファイルを上書きします。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            // OKボタンを押すとcsvファイルを上書き
            if(result == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName, false, Encoding.UTF8))
                {
                    // 見出し行をswに格納
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (i < dt.Columns.Count - 1)
                        {
                            sw.Write(dt.Columns[i] + ",");          // 最終列でなければカンマ
                        }
                        else
                        {
                            sw.Write(dt.Columns[i] + "\r\n");       // 最終列を書き込んだら改行
                        }
                    }
                    // データ部分をswに格納
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < dt.Columns.Count - 1; i++)
                        {
                            sw.Write("\"" + dr[i] + "\"");          // 各列のデータを「""」で囲み、 sw に格納
                            sw.Write(',');                          // 最終列でなければカンマ
                        }
                        sw.Write("\"" + dr[dt.Columns.Count - 1] + "\"");   // 最終列のデータを「""」で囲み、sw に格納
                        sw.Write("\r\n");                                   // 最終列を書き込んだら改行
                    }
                    MessageBox.Show("CSVファイルが上書きされました。");
                    // データグリッドビュー内の全てのセルの文字色を黒に
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for(int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        // テキストボックスを配列にして返す
        public TextBox[] GetTextBoxes()
        {
            TextBox[] tbArray = new TextBox[21];
            tbArray[0] = idBox;
            tbArray[1] = questionBox;
            tbArray[2] = choiceBox1;
            tbArray[3] = choiceBox2;
            tbArray[4] = choiceBox3;
            tbArray[5] = choiceBox4;
            tbArray[6] = choiceBox5;
            tbArray[7] = choiceBox6;
            tbArray[8] = choiceBox7;
            tbArray[9] = qDebBox1;
            tbArray[10] = qDebmoBox1;
            tbArray[11] = qCreBox1;
            tbArray[12] = qCremoBox1;
            tbArray[13] = qDebBox2;
            tbArray[14] = qDebmoBox2;
            tbArray[15] = qCreBox2;
            tbArray[16] = qCremoBox2;
            tbArray[17] = qDebBox3;
            tbArray[18] = qDebmoBox3;
            tbArray[19] = qCreBox3;
            tbArray[20] = qCremoBox3;

            return tbArray;
        }

        // 行全体を選択すると各テキストボックスに各セルのデータを表示
        private void RowHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBox[] tbArray = GetTextBoxes();
            for (int i = 0; i < tbArray.Length; i++)
            {
                tbArray[i].Clear();                 // 現在表示されているテキストボックス内のデータを削除
            }
            int rowIndex = e.RowIndex;              // 選択した行のインデックスを取得
            string[] data = new string[dataGridView1.Columns.Count];    // 列の数だけ配列を用意
            op = new Operation2();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                data[i] = dataGridView1.Rows[rowIndex].Cells[i].Value.ToString();       // 各セルのデータを配列に格納
            }
            op.TextBoxInsertString(tbArray, data);          // 配列のデータを各テキストボックスに格納
        }

        // セルの内容が変更されると文字色が赤に
        private void DataGridView1CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            dataGridView1.Rows[row].Cells[col].Style.ForeColor = Color.Red;
        }

        // 金額欄の数字に3桁ごとにカンマ挿入
        private void QDebmoBox1TextChanged(object sender, EventArgs e)
        {
            op = new Operation2();
            op.CommaInsert(qDebmoBox1);
        }

        private void QDebmoBox2TextChanged(object sender, EventArgs e)
        {
            op = new Operation2();
            op.CommaInsert(qDebmoBox2);
        }

        private void QDebmoBox3TextChanged(object sender, EventArgs e)
        {
            op = new Operation2();
            op.CommaInsert(qDebmoBox3);
        }

        private void QCremoBox1TextChanged(object sender, EventArgs e)
        {
            op = new Operation2();
            op.CommaInsert(qCremoBox1);
        }

        private void QCremoBox2TextChanged(object sender, EventArgs e)
        {
            op = new Operation2();
            op.CommaInsert(qCremoBox2);
        }

        private void QCremoBox3TextChanged(object sender, EventArgs e)
        {
            op = new Operation2();
            op.CommaInsert(qCremoBox3);
        }

        // フォーカスを外すとテキストボックス内のデータを対応セルにコピー
        private void QuestionBoxValidated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, questionBox, 1);
        }
        
        private void ChoiceBox1Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, choiceBox1, 2);
        }

        private void ChoiceBox2Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, choiceBox2, 3);
        }

        private void ChoiceBox3Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, choiceBox3, 4);
        }

        private void ChoiceBox4Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, choiceBox4, 5);
        }

        private void ChoiceBox5Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, choiceBox5, 6);
        }

        private void ChoiceBox6Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, choiceBox6, 7);
        }

        private void ChoiceBox7Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, choiceBox7, 8);
        }

        private void QDebBox1Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qDebBox1, 9);
        }

        private void QDebBox2Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qDebBox2, 13);
        }

        private void QDebBox3Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qDebBox3, 17);
        }

        private void QDebmoBox1Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qDebmoBox1, 10);
        }

        private void QDebmoBox2Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qDebmoBox2, 14);
        }

        private void QDebmoBox3Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qDebmoBox3, 18);
        }

        private void QCreBox1Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qCreBox1, 11);
        }

        private void QCreBox2Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qCreBox2, 15);
        }

        private void QCreBox3Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qCreBox3, 19);
        }

        private void QCremoBox1Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qCremoBox1, 12);
        }

        private void QCremoBox2Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qCremoBox2, 16);
        }

        private void QCremoBox3Validated(object sender, EventArgs e)
        {
            op = new Operation2();
            op.InsertDataGridView(dataGridView1, idBox, qCremoBox3, 20);
        }

        // 「ID」列の値が重複した場合はエラーメッセージ表示
        private void DataGridView1DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("入力したIDはすでに設定されています。\r\n別の値を入力してください。");
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
        }
    }
}
