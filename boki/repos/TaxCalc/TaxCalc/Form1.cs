using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButtonClicked(object sender, EventArgs e)
        {
            this.taxPriceBox.Text = null;
            this.Taxb.Text = null;

            int price;
            bool success = int.TryParse(this.priceBox.Text, out price);
          
            if (success)
            {
                int taxprice = (int)(price * 1.1);
                this.taxPriceBox.Text = taxprice.ToString();
                int tax = (int)(price * 0.1);
                this.Taxb.Text = tax.ToString();

            }
            else
            {
                MessageBox.Show("税抜価格を正しく入力してください");
               
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.b.Text = null;
            this.c.Text = null;

            int price1;
            bool success = int.TryParse(this.a.Text, out price1);

            if (success)
            {
                int taxprice = (int)(price1 /1.1);
                this.b.Text = taxprice.ToString();
                int tax = (int)(price1- (price1 / 1.1));
                this.c.Text = tax.ToString();

            }
            else
            {
                MessageBox.Show("税込価格を正しく入力してください");
              
              
            }
        }
    }
}
