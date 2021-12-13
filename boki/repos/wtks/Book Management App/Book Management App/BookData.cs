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
        private DataTable dataTable = new DataTable();

        protected override void OnLoad(EventArgs e)
        {
            bookDataGrid.DataSource = dataTable;
            base.OnLoad(e);
        }
        public BookData()
        {
            InitializeComponent();

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
    }
}
