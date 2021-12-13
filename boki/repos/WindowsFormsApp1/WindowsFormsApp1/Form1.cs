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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> citynames;
        public Form1()
        {
            InitializeComponent();
            this.citynames = new Dictionary<string, string>();

            this.citynames.Add("東京都", "3");
            this.citynames.Add("大阪府", "1");
            this.citynames.Add("愛知県", "2");
            this.citynames.Add("福岡県", "10");
            this.citynames.Add("新潟県", "6");
            foreach (KeyValuePair<string,string>data in this.citynames)
            {
                areaBox.Items.Add(data.Key);
            }

        }

        private void cityselected(object sender, EventArgs e)
        {
            string citycode = citynames[areaBox.Text];
            string url = "http://and-idea.sbcr.jp/sp/90261/weatherCheck.php?city=" + citycode;
            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;
            MessageBox.Show(result);
            JObject jobj = JObject.Parse(result);
            string todayweatherIcon = (string)((jobj["url"] as JValue).Value);
            weathericon.ImageLocation = todayweatherIcon;
          
            string todaytem = (string)((jobj["temp"] as JValue).Value);
            textBox1.Text = todaytem;

        }

        private void ExitMenuClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
