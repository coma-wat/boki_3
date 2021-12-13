
namespace DrawApp
{
    partial class Pallet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circlebutton = new System.Windows.Forms.Button();
            this.rectanglebutton = new System.Windows.Forms.Button();
            this.linebutton = new System.Windows.Forms.Button();
            this.pensizeBox = new System.Windows.Forms.TextBox();
            this.colorbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circlebutton
            // 
            this.circlebutton.Location = new System.Drawing.Point(23, 40);
            this.circlebutton.Name = "circlebutton";
            this.circlebutton.Size = new System.Drawing.Size(128, 114);
            this.circlebutton.TabIndex = 0;
            this.circlebutton.Text = "Circle";
            this.circlebutton.UseVisualStyleBackColor = true;
            this.circlebutton.Click += new System.EventHandler(this.CircleButtonClicked);
            // 
            // rectanglebutton
            // 
            this.rectanglebutton.Location = new System.Drawing.Point(189, 40);
            this.rectanglebutton.Name = "rectanglebutton";
            this.rectanglebutton.Size = new System.Drawing.Size(122, 115);
            this.rectanglebutton.TabIndex = 1;
            this.rectanglebutton.Text = "Rectangle";
            this.rectanglebutton.UseVisualStyleBackColor = true;
            this.rectanglebutton.Click += new System.EventHandler(this.RectButtonClicked);
            // 
            // linebutton
            // 
            this.linebutton.Location = new System.Drawing.Point(356, 40);
            this.linebutton.Name = "linebutton";
            this.linebutton.Size = new System.Drawing.Size(121, 114);
            this.linebutton.TabIndex = 2;
            this.linebutton.Text = "Line";
            this.linebutton.UseVisualStyleBackColor = true;
            this.linebutton.Click += new System.EventHandler(this.LineButtonClicked);
            // 
            // pensizeBox
            // 
            this.pensizeBox.Location = new System.Drawing.Point(520, 117);
            this.pensizeBox.Name = "pensizeBox";
            this.pensizeBox.Size = new System.Drawing.Size(106, 19);
            this.pensizeBox.TabIndex = 3;
            this.pensizeBox.Text = "3";
            // 
            // colorbutton
            // 
            this.colorbutton.BackColor = System.Drawing.SystemColors.WindowText;
            this.colorbutton.Location = new System.Drawing.Point(536, 71);
            this.colorbutton.Name = "colorbutton";
            this.colorbutton.Size = new System.Drawing.Size(54, 34);
            this.colorbutton.TabIndex = 4;
            this.colorbutton.Text = "button4";
            this.colorbutton.UseVisualStyleBackColor = false;
            this.colorbutton.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // Pallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 176);
            this.Controls.Add(this.colorbutton);
            this.Controls.Add(this.pensizeBox);
            this.Controls.Add(this.linebutton);
            this.Controls.Add(this.rectanglebutton);
            this.Controls.Add(this.circlebutton);
            this.Name = "Pallet";
            this.Text = "Pallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circlebutton;
        private System.Windows.Forms.Button rectanglebutton;
        private System.Windows.Forms.Button linebutton;
        private System.Windows.Forms.TextBox pensizeBox;
        private System.Windows.Forms.Button colorbutton;
    }
}