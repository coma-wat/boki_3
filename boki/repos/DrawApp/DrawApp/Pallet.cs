using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Pallet : Form
    {
        int figurType;
        public int GetFigureType()
            {
            return figurType;
        }

        public int GetPenSize()
        {
            int size;
            if(int.TryParse(this.pensizeBox.Text,out size))
            {
                return size;
            }
            else
            {
                return 1;
            }

           
        }
        public Color GetColor()
        {
            return colorbutton.BackColor;
        }

        public Pallet()
        {
            InitializeComponent();
            this.figurType = 1;
        }

        private void CircleButtonClicked(object sender, EventArgs e)
        {
            this.figurType = 1;

        }

        private void RectButtonClicked(object sender, EventArgs e)
        {
            this.figurType = 2;
        }

        private void LineButtonClicked(object sender, EventArgs e)
        {
            this.figurType = 3;
        }

        private void ColorButtonClicked(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                colorbutton.BackColor = colorDialog.Color;
            }

        }
    }
}
