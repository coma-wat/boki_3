using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbuttonclicked(object sender, EventArgs e)
        {
            DialogResult dialog=MessageBox.Show("登録してもいいですか？","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)

            {
                bookDataSet1.bookdatatable.AddbookdatatableRow(
                  this.bookname.Text, this.author.Text, int.Parse(this.price.Text));
            }

        }

        private void removebuttonclicked(object sender, EventArgs e)
        {
            int row = this.bookDataGrid.CurrentRow.Index;
            this.bookDataGrid.Rows.RemoveAt(row);

        }
        

  /*      private void bookDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            this.bookname.Text = bookDataGrid.CurrentRow.Cells[0].Value.ToString();
            this.author.Text = bookDataGrid.CurrentRow.Cells[1].Value.ToString();
            this.price.Text = bookDataGrid.CurrentRow.Cells[2].Value.ToString();

        }
  */

        



    }
}
