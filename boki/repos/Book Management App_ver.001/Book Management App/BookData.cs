using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Book_Management_App
{
    public partial class BookData : Form
    {
        Form1 f1;
        private DataTable dataTable = new DataTable();

        protected override void OnLoad(EventArgs e)
        {
            bookDataGrid.DataSource = dataTable;
            base.OnLoad(e);
        }
        public BookData(Form1 f)
        {
            f1 = f;
            InitializeComponent();

            // データテーブルに「data.db」ファイルの値を読み込んで表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=data.db"))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM 書籍一覧", con))
            {
                adapter.Fill(dataTable);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime nowdt = DateTime.Now;
            timeBox.Text = nowdt.ToString();
        }

        private void updateButtonClicked(object sender, EventArgs e)
        {
            dataTable.Clear();      // 古いデータテーブルを削除
            // データテーブルに更新後の「data.db」のデータを読み込んで表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=data.db"))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM 書籍一覧", con))
            {
                adapter.Fill(dataTable);
            }
        }

        private void BookDataGridClicked(object sender, DataGridViewCellEventArgs e)
        {
            f1.IdBox.Text = this.bookDataGrid.CurrentRow.Cells[0].Value.ToString();
            f1.BookNameBox.Text = this.bookDataGrid.CurrentRow.Cells[1].Value.ToString();
            f1.AuthorBox.Text = this.bookDataGrid.CurrentRow.Cells[2].Value.ToString();
            f1.GenreBox.Text = this.bookDataGrid.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
