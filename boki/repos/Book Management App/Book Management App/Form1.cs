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
    public partial class Form1 : Form
    {
        BookData BookData;
        public Form1()
        {
            InitializeComponent();
            this.BookData = new BookData();
            BookData.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            cmd.CommandText = IdBox.Text;

        }
    }
}
