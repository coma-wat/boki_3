using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void rituselected(object sender, EventArgs e)
        {
           

        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            int price;
            bool success= int.TryParse(this. pricetBox .Text, out price);
            if(success)
            {
                if (radio10Button.Checked)
                {
                    if (floorButton.Checked)

                    {
                        double taxprice = Math.Floor(price * 1.1);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if (roundButton.Checked)
                    {
                        double taxprice = Math.Round(price * 1.1);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if (ceilingButton.Checked)
                    {
                        double taxprice = Math.Ceiling(price * 1.1);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                }
                 if(radio5Button.Checked)
                {
                    if (floorButton.Checked)
                    {
                        double taxprice = Math.Floor(price * 1.05);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if(roundButton.Checked)
                    {
                        double taxprice = Math.Floor(price * 1.05);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if(ceilingButton.Checked)
                    {
                        double taxprice = Math.Ceiling(price * 1.05);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                }
                 if (radio3Button.Checked)
                {
                    if (floorButton.Checked)
                    {
                        double taxprice = Math.Floor(price * 1.03);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if(roundButton.Checked)
                    {
                        double taxprice = Math.Round(price * 1.03);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if (ceilingButton.Checked)
                    {
                        double taxprice = Math.Ceiling(price * 1.03);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                }
                if (radio8Button.Checked)
                {
                    if (floorButton.Checked)
                    {
                        double taxprice = Math.Floor(price * 1.08);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if (roundButton.Checked)
                    {
                        double taxprice = Math.Round(price * 1.08);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                    else if (ceilingButton.Checked)
                    {
                        double taxprice = Math.Ceiling(price * 1.08);
                        this.taxpricetextBox.Text = taxprice.ToString();
                    }
                }
               

            }
            else
            MessageBox.Show("価格を正しく入力してください。");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tprice;
            bool success = int.TryParse(this.textBox1.Text, out tprice);
            if (success)
            {
                if (radio10.Checked)
                {
                    if (radiofloor.Checked)
                    {
                        double taxprice = Math.Floor(tprice / 1.1);
                        this.textBox2.Text = taxprice.ToString();
                    }
                    else if(radioround.Checked)
                    {
                        double taxprice = Math.Round(tprice / 1.1);
                        this.textBox2.Text = taxprice.ToString();

                    }
                    else if (radioceiling.Checked)
                    {
                        double taxprice = Math.Ceiling(tprice / 1.1);
                        this.textBox2.Text = taxprice.ToString();

                    }

                }
                if (radio5.Checked)
                {
                    if (radiofloor.Checked)
                   {
                        double taxprice = Math.Floor(tprice / 1.05);
                        this.textBox2.Text = taxprice.ToString();
                    }
                    else if(radioround.Checked)
                    {
                        double taxprice = Math.Round(tprice / 1.05);
                        this.textBox2.Text = taxprice.ToString();
                    }
                    else if (radioceiling.Checked)
                    {
                        double taxprice = Math.Ceiling(tprice / 1.05);
                        this.textBox2.Text = taxprice.ToString();

                    }

                }
                if (radio3.Checked)
                {
                    if (radiofloor.Checked)
                    {
                        double taxprice = Math.Floor(tprice / 1.03);
                        this.textBox2.Text = taxprice.ToString();
                    }
                    else if (radioround.Checked)
                    {
                        double taxprice = Math.Round(tprice / 1.03);
                        this.textBox2.Text = taxprice.ToString();
                    }
                    else if (radioceiling.Checked)
                    {
                        double taxprice = Math.Ceiling(tprice / 1.03);
                        this.textBox2.Text = taxprice.ToString();

                    }
                }
              if (radio8.Checked)
                {
                    if (radiofloor.Checked)
                    {
                        double taxprice = Math.Floor(tprice / 1.08);
                        this.textBox2.Text = taxprice.ToString();
                    }
                    else if (radioround.Checked)
                    {
                        double taxprice = Math.Round(tprice / 1.08);
                        this.textBox2.Text = taxprice.ToString();
                    }
                    else if (radioceiling.Checked)
                    {
                        double taxprice = Math.Ceiling(tprice / 1.08);
                        this.textBox2.Text = taxprice.ToString();

                    }
                }
               
            }
            else
                MessageBox.Show("価格を正しく入力してください。");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (taxpricetextBox.Text != "")
            {
                Clipboard.SetText(taxpricetextBox.Text);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (taxpricetextBox.Text != "")
            {
                Clipboard.SetText(textBox2.Text);
            }
        }

        
    }
}
