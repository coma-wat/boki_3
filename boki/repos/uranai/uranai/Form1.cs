using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace uranai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seiza = comboBox1.Text;
            string url = "http://api.jugemkey.jp/api/horoscope/" + seiza;
            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;
            JObject jobi = JObject.Parse(result);
            string today=(string)((jobi["horoscope"]["sigt"]["rank"]as JValue).Value);
            listBox1.Text = today;
            

        }
    }
}
