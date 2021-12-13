using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jynkenpon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            

            Random a = new Random();
            int aite = a.Next(1, 4);
            int jibu = 1;
           
            if (aite == jibu)
            {
                textBox1.Text = "あいこ";
            }
            else if(jibu==1&&aite==2)
                {
                textBox1.Text = "あなたの勝ち";
            }
            else if(jibu==1&&aite==2)
            {
                textBox1.Text = "相手の勝ち";
            }

            

            textBox2.Text = "グー";
            if(aite==1)
            {
                textBox3.Text = "グー";
            }
            else if(aite==2)
            {
                textBox3.Text = "チョキ";
            }
            else if (aite == 3)
            {
                textBox3.Text = "パー";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            int aite = a.Next(1, 4);
            int jibu = 2;
            if (aite == jibu)
            {
                textBox1.Text = "あいこ";
            }
            else if (jibu==2 && aite == 3)
            {
                textBox1.Text = "あなたの勝ち";
            }
            else if (jibu == 2 && aite == 1)
            {
                textBox1.Text = "相手の勝ち";
            }


            textBox2.Text = "チョキ";
            if (aite == 1)
            {
                textBox3.Text = "グー";
            }
            else if (aite == 2)
            {
                textBox3.Text = "チョキ";
            }
            else if (aite == 3)
            {
                textBox3.Text = "パー";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            int aite = a.Next(1, 4);
            int jibu = 3;
            if (aite == jibu)
            {
                textBox1.Text = "あいこ";
            }
            else if (jibu == 3 && aite == 1)
            {
                textBox1.Text = "あなたの勝ち";
            }
            else if (jibu == 3 && aite == 2)
            {
                textBox1.Text = "相手の勝ち";
            }


            textBox2.Text = "パー";
            if (aite == 1)
            {
                textBox3.Text = "グー";
            }
            else if (aite == 2)
            {
                textBox3.Text = "チョキ";
            }
            else if (aite == 3)
            {
                textBox3.Text = "パー";
            }
        }
    }
}
