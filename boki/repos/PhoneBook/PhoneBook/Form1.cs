using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> phoneBook;

        public Form1()
        {
            InitializeComponent();

            this.phoneBook = new Dictionary<string, string>();

            ReadFromFile();


  /*          this.phoneBook.Add("山田一郎", "050-3456-4343");　//プログラム内にデータ
            this.phoneBook.Add("山田二郎", "050-8823-9434");
            this.phoneBook.Add("山田三郎", "050-7935-2117");
            this.phoneBook.Add("山田史郎", "050-1693-7364");
  */


            foreach(KeyValuePair<string,string> data in phoneBook)
             {
                this.nameList .Items.Add(data.Key);

            }

            
  


        }
        private void ReadFromFile()
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\data.txt"))
               
            {
                while(!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(',');
                    this.phoneBook.Add(data[0], data[1]);
                }
            }
        }

        private void NameSelected(object sender, EventArgs e)
        {
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name];
            int no = this.nameList.SelectedIndex;
            string phptpno = @"..\..\photo\" + no.ToString() + ".jpeg";
            this.pictureBox1.ImageLocation = phptpno;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        

    }
}
