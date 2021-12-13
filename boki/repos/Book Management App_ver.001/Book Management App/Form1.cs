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
            BookData = new BookData(this);
            BookData.Show();

            ReadFormFile();
           
        }
        private void ReadFormFile()
        {
            using(System.IO.StreamReader file=new System.IO.StreamReader(@"..\..\TextFile1.txt"))
            {
                while(!file.EndOfStream)
                {
                    string Line = file.ReadLine();
                   this.listBox1.Items.Add(Line) ;
                }
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            DataView dtview = dtview = new DataView();

       dtview.ToTable(true,"ID");
            if(IdBox.Text==BookData.


            
            
                MessageBox.Show("IDが重複しています");
            
            
            if (IdBox.Text == "" || BookNameBox.Text == "" || AuthorBox.Text == "" || listBox1.Text == "")
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
                    string str = "INSERT INTO 書籍一覧 VALUES(" + "\'" + IdBox.Text + "\',\'" + BookNameBox.Text + "\',\'" + AuthorBox.Text + "\',\'" + listBox1.Text + "\')";
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            if (IdBox.Text == "")
            {
                MessageBox.Show("IDが入力されていません。IDを入力して下さい。", "入力エラー");
            }
            else
            {
                DialogResult result = MessageBox.Show("ID番号" + IdBox.Text + "の行項目を削除しますか？", "項目の削除", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "data.db" };
                    var cn = new SQLiteConnection(sqlConnectionSb.ToString());

                    cn.Open();
                    var cmd = new SQLiteCommand(cn);
                    cmd.CommandText = "DELETE FROM 書籍一覧 WHERE ID ='" + IdBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        private void ChangeButtonClicked(object sender, EventArgs e)
        {
            if (IdBox.Text == "" || BookNameBox.Text == "" || AuthorBox.Text == "" || GenreBox.Text == "")
            {
                MessageBox.Show("未入力の項目があります。", "入力エラー");
            }
            else
            {
                DialogResult result = MessageBox.Show("変更した内容で登録しますか？", "変更の確認", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    // ここに変更するための処理を入力
                    var sqlConnectionSb = new SQLiteConnectionStringBuilder { DataSource = "data.db" };
                    var cn = new SQLiteConnection(sqlConnectionSb.ToString());

                    cn.Open();
                    var cmd = new SQLiteCommand(cn);
                    cmd.CommandText = "UPDATE 書籍一覧 SET 著者=" + "\"" + AuthorBox.Text + "\"" + ",書籍名=" + "\"" + BookNameBox.Text + "\"" + ",ジャンル=" + "\"" + GenreBox.Text + "\"" + "WHERE ID =\'" + IdBox.Text + "\'";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
