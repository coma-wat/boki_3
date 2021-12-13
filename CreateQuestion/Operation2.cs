using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CreateQuestion
{
    class Operation2
    {
        // 各金額のテキストボックスに半角数字を入力すると3桁ごとにカンマ挿入
        public void CommaInsert(TextBox tb)
        {
            string moTemp = tb.Text.Replace(",", "");           // 金額欄に入力された数字をlong型にするためにカンマを消去
            long value;                                         // 10億以上を入力できるようにlong型に
            bool success = long.TryParse(moTemp, out value);    // string型⇒long型に変換できたら success に true を格納し value に変換した数字を格納
            // 金額欄が空欄の時は success に true を格納
            if (moTemp == "")
            {
                success = true;
            }
            // long型に変換できればstring型に変換してカンマを挿入
            if (!success)
            {
                MessageBox.Show("金額は半角数字で入力してください");    // 数字以外が入力されると警告
                tb.ForeColor = Color.Red;                               // 文字色を赤に
            }
            else if (moTemp != "")          // 金額欄が空欄でなく、かつ数字であればカンマを挿入してテキストボックスに格納
            {
                tb.Text = string.Format("{0:#,0}", value);      // long型⇒string型に変換し、3桁ごとにカンマを挿入
                tb.ForeColor = Color.Black;                     // 文字色を黒に
                tb.SelectionStart = tb.TextLength;              // 文字の入力位置を数字の末尾に
            }
        }

        // 各テキストボックスにデータグリッドビューの指定行データを格納
        public void TextBoxInsertString(TextBox[] tbArray, string[] data)
        {
            for (int i = 0; i < tbArray.Length; i++)
            {
                tbArray[i].Text = data[i];
            }
        }

        // テキストボックスのデータをデータグリッドビューの対応するセルに格納
        public void InsertDataGridView(DataGridView dg, TextBox idBox, TextBox tb, int n)
        {
            for (int i = 0; i < dg.Rows.Count - 1; i++)
            {
                if (idBox.Text == dg.Rows[i].Cells["ID"].Value.ToString())
                {
                    dg.Rows[i].Cells[n].Value = tb.Text;
                }
            }
        }
    }
}
