using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rennsyu
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void area(object sender, EventArgs e)
        {

            MessageBox.Show(todohuken.Text+"番号は"+todohuken.SelectedIndex);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kakunin1(object sender, EventArgs e)
        {
            /* string msg = "";



             if (checkBox1.Checked)
             {
                 msg += checkBox1.Text+"\n";
             }
             if (checkBox2.Checked)
             {
                 msg += checkBox2.Text + "\n";
             }
             if (checkBox3.Checked)
             {
                 msg +=  checkBox3.Text + "\n";
             }
             if (checkBox4.Checked)
             {
                 msg +=  checkBox4.Text + "\n";
             }
             if (checkBox5.Checked)
             {
                 msg +=  checkBox5.Text + "\n";
             }

             if(msg　!="")
             {
                 msg = msg.Substring(0, msg.Length-1); 　　　　//後ろ一文字を消す
                 MessageBox.Show("確認項目は"+msg+"でした");

             }
             else
             {
                 MessageBox.Show("確認できませんでした");
             }
            */
            if (checkBox5.Checked && textBox1.Text == "") //その他
            {
                MessageBox.Show("その他に記入してください");

            }
            else
            {


                List<string> msg = new List<string>();


                if (checkBox1.Checked)
                {
                    msg.Add(checkBox1.Text);
                }

                if (checkBox2.Checked)
                {
                    msg.Add(checkBox2.Text);
                }

                if (checkBox3.Checked)
                {
                    msg.Add(checkBox3.Text);
                }

                if (checkBox4.Checked)
                {
                    msg.Add(checkBox4.Text);
                }
                if (checkBox5.Checked)//その他
                {

                    
                    msg.Add(checkBox5.Text + textBox1.Text);

                }


                if (msg.Count > 0)
                {
                    
                    MessageBox.Show("確認項目は" + string.Join("/", msg) + "でした");

                }
                else
                {
                    MessageBox.Show("確認項目はありません");

                }


            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (radioButton5.Checked&&textBox2.Text=="")
            {
                MessageBox.Show("とても悪かった理由をお書きください。");
            }

            
           else if(radioButton1.Checked)
                
            {
                msg=radioButton1.Text;

            }
           else if (radioButton2.Checked)
            {
                msg = radioButton2.Text;

            }
            else if (radioButton3.Checked)
            {
                msg = radioButton3.Text;

            }
            else if (radioButton4.Checked)
            {
                msg = radioButton4.Text;

            }
            else if (radioButton5.Checked)
            {
                msg = radioButton5.Text+textBox2.Text;

            }
            else
            {
                msg="確認できません";
            }
            MessageBox.Show(msg);
        
       
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
               textBox2.Enabled = false;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
