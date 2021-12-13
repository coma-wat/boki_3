using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jyanken_mvsm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
     
      
     

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton6.Checked)
            {
                textBox1.Text = "あいこ";
            }
            else if (radioButton2.Checked && radioButton5.Checked)
            {
                textBox1.Text = "あいこ";
            }
            else if (radioButton3.Checked && radioButton4.Checked)
            {
                textBox1.Text = "あいこ";
            }
            if (radioButton1.Checked && radioButton5.Checked)
            {
                textBox1.Text = "マリオの勝ち";
            }
            if (radioButton1.Checked && radioButton4.Checked)
            {
                textBox1.Text = "ルイージの勝ち";
            }
            if (radioButton2.Checked && radioButton4.Checked)
            {
                textBox1.Text = "マリオの勝ち";
            }
            if (radioButton2.Checked && radioButton6.Checked)
            {
                textBox1.Text = "ルイージの勝ち";
            }
            if (radioButton3.Checked && radioButton6.Checked)
            {
                textBox1.Text = "マリオの勝ち";
            }
            if (radioButton3.Checked && radioButton5.Checked)
            {
                textBox1.Text = "ルイージの勝ち";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Visible==false)
            {
                radioButton1.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
            }
            if (radioButton2.Visible == false)
            {
                radioButton2.Visible = true;
            }
            else
            {
                radioButton2.Visible = false;
            }
            if (radioButton3.Visible == false)
            {
                radioButton3.Visible = true;
            }
            else
            {
                radioButton3.Visible = false;
            }
            
        }
    }
}
