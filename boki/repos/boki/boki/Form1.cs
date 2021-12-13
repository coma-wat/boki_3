using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFromFile();
        }
        private void ReadFromFile()
        {
            using(System.IO.StreamReader file=new System.IO.StreamReader(@)
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd;
            int seed;
            seed = Environment.TickCount;
            rnd = new Random(seed);
            

        }
    }
}
