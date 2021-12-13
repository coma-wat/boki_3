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
    public partial class 書籍管理 : Form
    {
        BookData BookData;
        public 書籍管理()
        {
            InitializeComponent();
            this.BookData = new BookData();
            BookData.Show();
           
        }
        private void IdBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
  
        {
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
                return;
            }

        }

        private void addButton_Click(object sender, EventArgs e)

        {
            if (IdBox.Text == "" || BookNameBox.Text == "" || AuthorBox.Text == "" || GenreBox.Text == "")
            {
                MessageBox.Show("未入力の項目があります。", "入力エラー");
            }

            else
            {
                DialogResult result = MessageBox.Show("入力した内容を登録しますか？", "登録の確認", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)


                {
                    var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "data.db" };
                    var cn = new SQLiteConnection(sqlConnectionSb.ToString());

                    cn.Open();

                    var cmd = new SQLiteCommand(cn);



                    string str = "INSERT INTO 書籍一覧 VALUES(" + "\'" + IdBox.Text + "\',\'" + BookNameBox.Text + "\',\'" + AuthorBox.Text + "\',\'" + GenreBox.Text + "\')";

                    cmd.CommandText = str;

                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }


            
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            

            var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "data.db" };
            var cn = new SQLiteConnection(sqlConnectionSb.ToString());

            cn.Open();

            var cmd = new SQLiteCommand(cn);



            cmd.CommandText = "UPDATE 書籍一覧 SET ID='55'" +
                "WHERE 書籍名='b'";
            cmd.ExecuteNonQuery();




            cn.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
