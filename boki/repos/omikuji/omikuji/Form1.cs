using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omikuji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd;
            int seed;
            int un;
            string[] unsei ={ "大吉", "中吉", "末吉","凶","大凶"};
            string[] sogo = { "四方吉。存分に立ち回るべし。", "まずまずの結果が得られる。", "判断が遅いとよくない結果に。", "鬼門に気を付ければ吉へ向かう。", "我慢の期間なため、派手に動かず。" };
            string[] renai ={"これまでの努力が大きく花開く。","新たな始まりが良い方向に。","二兎追うものは一兎をも得ず","よく観察することで吉報に。","待ち人来たらず"
                           };
            string[] kinun ={"少しの辛抱から大きな結果に。","「左」が運気アップのきっかけに。","狙いは絞って","逃げるが勝ちとなる場合が多い。","安物買いの銭失い"
                           };

            seed = Environment.TickCount;
            rnd = new Random(seed);
            un = rnd.Next(0, 5);
            textBox1.Text = unsei[un];
            textBox2.Text = sogo[un];
            textBox3.Text = renai[un];
            textBox4.Text = kinun[un];
            float kaisu;
            
            float da = 0;
            float tu = 0; 
            float su = 0; 
            float ky = 0; 
            float dky = 0;
            if (un == 0)
            {
                da++;
               
            }
            else if (un == 1) 
            {
                tu++;
               
            }
          else if (un == 3)
            {
                su++;
           
            }
            else if (un == 4)
            {
                ky++;
              
            }
            else if (un == 5)
            {
                dky++;
              
            }

            textBoxdai.Text = da.ToString();
            textBoxtyu.Text =tu.ToString();
            textBoxsue.Text =su.ToString();
            textBoxkyo.Text = ky.ToString();
            textBoxdkyo.Text = dky.ToString();
          

           
        }

        private void textBoxkyo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxdai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtyu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
