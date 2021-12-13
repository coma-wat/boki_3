using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawApp
{
    public partial class Form1 : Form
    {
        Point startPos, endPos;
        Pallet pallet;
        public Form1()
        {
            InitializeComponent();
            this.pallet = new Pallet();
            pallet.Show();
        }

        private void DrawFigures(object sender, PaintEventArgs e)
        {
            /*          e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        SolidBrush brush = new SolidBrush(Color.GreenYellow);
                        e.Graphics.FillEllipse(brush, 15,15,200, 200);
                        e.Graphics.FillEllipse(brush, 210,210,100,100);
                        SolidBrush brush1= new SolidBrush(Color.Green);
                        e.Graphics.FillRectangle(brush1, 220, 15, 150, 150);
            
            SolidBrush brush = new SolidBrush(Color.GreenYellow);
            int width = this.endPos.X - this.startPos.X;
            int height = this.endPos.Y - this.startPos.Y;
            e.Graphics.FillEllipse(brush, this.startPos.X, this.startPos.Y, width, height);
            */

            int type = this.pallet.GetFigureType();
            Color color = this.pallet.GetColor();

            int penSize = this.pallet.GetPenSize();
            if(type==1)
            {
                SolidBrush brush = new SolidBrush(color);
                int width = this.endPos.X - this.startPos.X;
                int height = this.endPos.Y - this.endPos.Y;
                e.Graphics.FillEllipse(brush, this.startPos.X, this.startPos.Y, width, height);
            }
            else if(type==2)
            {
                SolidBrush brush = new SolidBrush(color);
                int width = this.endPos.X - this.startPos.X;
                int height = this.endPos.Y - this.startPos.X;
                e.Graphics.FillRectangle
                    (brush, this.startPos.X, this.startPos.Y, width, height);


            }
            else if(type == 3)
                {
                Pen p = new Pen(color, penSize);
                e.Graphics.DrawLine(p, this.startPos.X, this.startPos.Y,this.endPos.X, this.endPos.Y);
                    

            }










        }

        private void MousePressed(object sender, MouseEventArgs e)
        {
            this.startPos = new Point(e.X, e.Y);

        }

        private void MouseDragged(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.endPos = new Point(e.X, e.Y);
                Invalidate();

            }
        }
    }
}
