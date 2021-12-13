
namespace _7_1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pricetBox = new System.Windows.Forms.TextBox();
            this.taxpricetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.roundButton = new System.Windows.Forms.RadioButton();
            this.floorButton = new System.Windows.Forms.RadioButton();
            this.ceilingButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioround = new System.Windows.Forms.RadioButton();
            this.radiofloor = new System.Windows.Forms.RadioButton();
            this.radioceiling = new System.Windows.Forms.RadioButton();
            this.radio3Button = new System.Windows.Forms.RadioButton();
            this.radio5Button = new System.Windows.Forms.RadioButton();
            this.radio8Button = new System.Windows.Forms.RadioButton();
            this.radio10Button = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio10 = new System.Windows.Forms.RadioButton();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pricetBox
            // 
            this.pricetBox.Location = new System.Drawing.Point(100, 163);
            this.pricetBox.Name = "pricetBox";
            this.pricetBox.Size = new System.Drawing.Size(119, 19);
            this.pricetBox.TabIndex = 0;
          
            // 
            // taxpricetextBox
            // 
            this.taxpricetextBox.Enabled = false;
            this.taxpricetextBox.Location = new System.Drawing.Point(101, 204);
            this.taxpricetextBox.Multiline = true;
            this.taxpricetextBox.Name = "taxpricetextBox";
            this.taxpricetextBox.Size = new System.Drawing.Size(118, 19);
            this.taxpricetextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "税抜き前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "税込";
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(131, 255);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(99, 29);
            this.calcbutton.TabIndex = 4;
            this.calcbutton.Text = "計算する";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "コピーする";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundButton
            // 
            this.roundButton.AutoSize = true;
            this.roundButton.Location = new System.Drawing.Point(44, 18);
            this.roundButton.Name = "roundButton";
            this.roundButton.Size = new System.Drawing.Size(71, 16);
            this.roundButton.TabIndex = 10;
            this.roundButton.TabStop = true;
            this.roundButton.Text = "四捨五入";
            this.roundButton.UseVisualStyleBackColor = true;
            // 
            // floorButton
            // 
            this.floorButton.AutoSize = true;
            this.floorButton.Location = new System.Drawing.Point(44, 37);
            this.floorButton.Name = "floorButton";
            this.floorButton.Size = new System.Drawing.Size(64, 16);
            this.floorButton.TabIndex = 11;
            this.floorButton.TabStop = true;
            this.floorButton.Text = "切り捨て";
            this.floorButton.UseVisualStyleBackColor = true;
            // 
            // ceilingButton
            // 
            this.ceilingButton.AutoSize = true;
            this.ceilingButton.Location = new System.Drawing.Point(44, 54);
            this.ceilingButton.Name = "ceilingButton";
            this.ceilingButton.Size = new System.Drawing.Size(65, 16);
            this.ceilingButton.TabIndex = 12;
            this.ceilingButton.TabStop = true;
            this.ceilingButton.Text = "切り上げ";
            this.ceilingButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "税抜き前";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "税込";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 19);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(422, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 19);
            this.textBox2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 22);
            this.button2.TabIndex = 19;
            this.button2.Text = "コピーする";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "計算する";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioround
            // 
            this.radioround.AutoSize = true;
            this.radioround.Location = new System.Drawing.Point(57, 18);
            this.radioround.Name = "radioround";
            this.radioround.Size = new System.Drawing.Size(71, 16);
            this.radioround.TabIndex = 22;
            this.radioround.TabStop = true;
            this.radioround.Text = "四捨五入";
            this.radioround.UseVisualStyleBackColor = true;
            // 
            // radiofloor
            // 
            this.radiofloor.AutoSize = true;
            this.radiofloor.Location = new System.Drawing.Point(57, 37);
            this.radiofloor.Name = "radiofloor";
            this.radiofloor.Size = new System.Drawing.Size(64, 16);
            this.radiofloor.TabIndex = 23;
            this.radiofloor.TabStop = true;
            this.radiofloor.Text = "切り捨て";
            this.radiofloor.UseVisualStyleBackColor = true;
            // 
            // radioceiling
            // 
            this.radioceiling.AutoSize = true;
            this.radioceiling.Location = new System.Drawing.Point(56, 59);
            this.radioceiling.Name = "radioceiling";
            this.radioceiling.Size = new System.Drawing.Size(65, 16);
            this.radioceiling.TabIndex = 24;
            this.radioceiling.TabStop = true;
            this.radioceiling.Text = "切り上げ";
            this.radioceiling.UseVisualStyleBackColor = true;
            // 
            // radio3Button
            // 
            this.radio3Button.AutoSize = true;
            this.radio3Button.Location = new System.Drawing.Point(15, 15);
            this.radio3Button.Name = "radio3Button";
            this.radio3Button.Size = new System.Drawing.Size(35, 16);
            this.radio3Button.TabIndex = 25;
            this.radio3Button.Text = "3%";
            this.radio3Button.UseVisualStyleBackColor = true;
            // 
            // radio5Button
            // 
            this.radio5Button.AutoSize = true;
            this.radio5Button.Location = new System.Drawing.Point(17, 37);
            this.radio5Button.Name = "radio5Button";
            this.radio5Button.Size = new System.Drawing.Size(35, 16);
            this.radio5Button.TabIndex = 26;
            this.radio5Button.Text = "5%";
            this.radio5Button.UseVisualStyleBackColor = true;
            // 
            // radio8Button
            // 
            this.radio8Button.AutoSize = true;
            this.radio8Button.Location = new System.Drawing.Point(70, 15);
            this.radio8Button.Name = "radio8Button";
            this.radio8Button.Size = new System.Drawing.Size(35, 16);
            this.radio8Button.TabIndex = 27;
            this.radio8Button.Text = "8%";
            this.radio8Button.UseVisualStyleBackColor = true;
            // 
            // radio10Button
            // 
            this.radio10Button.AutoSize = true;
            this.radio10Button.Location = new System.Drawing.Point(70, 37);
            this.radio10Button.Name = "radio10Button";
            this.radio10Button.Size = new System.Drawing.Size(41, 16);
            this.radio10Button.TabIndex = 28;
            this.radio10Button.Text = "10%";
            this.radio10Button.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio10Button);
            this.groupBox1.Controls.Add(this.radio8Button);
            this.groupBox1.Controls.Add(this.radio5Button);
            this.groupBox1.Controls.Add(this.radio3Button);
            this.groupBox1.Location = new System.Drawing.Point(23, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 59);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "消費税率入力";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio10);
            this.groupBox2.Controls.Add(this.radio8);
            this.groupBox2.Controls.Add(this.radio5);
            this.groupBox2.Controls.Add(this.radio3);
            this.groupBox2.Location = new System.Drawing.Point(357, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 59);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "消費税率入力";
            // 
            // radio10
            // 
            this.radio10.AutoSize = true;
            this.radio10.Location = new System.Drawing.Point(70, 37);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(41, 16);
            this.radio10.TabIndex = 28;
            this.radio10.TabStop = true;
            this.radio10.Text = "10%";
            this.radio10.UseVisualStyleBackColor = true;
            // 
            // radio8
            // 
            this.radio8.AutoSize = true;
            this.radio8.Location = new System.Drawing.Point(70, 15);
            this.radio8.Name = "radio8";
            this.radio8.Size = new System.Drawing.Size(35, 16);
            this.radio8.TabIndex = 27;
            this.radio8.TabStop = true;
            this.radio8.Text = "8%";
            this.radio8.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(17, 37);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(35, 16);
            this.radio5.TabIndex = 26;
            this.radio5.TabStop = true;
            this.radio5.Text = "5%";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(15, 15);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(35, 16);
            this.radio3.TabIndex = 25;
            this.radio3.TabStop = true;
            this.radio3.Text = "3%";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ceilingButton);
            this.groupBox3.Controls.Add(this.floorButton);
            this.groupBox3.Controls.Add(this.roundButton);
            this.groupBox3.Location = new System.Drawing.Point(153, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 84);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "端数処理方法入力";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioceiling);
            this.groupBox4.Controls.Add(this.radiofloor);
            this.groupBox4.Controls.Add(this.radioround);
            this.groupBox4.Location = new System.Drawing.Point(499, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 81);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "端数処理方法入力";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 315);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxpricetextBox);
            this.Controls.Add(this.pricetBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pricetBox;
        private System.Windows.Forms.TextBox taxpricetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton roundButton;
        private System.Windows.Forms.RadioButton floorButton;
        private System.Windows.Forms.RadioButton ceilingButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioround;
        private System.Windows.Forms.RadioButton radiofloor;
        private System.Windows.Forms.RadioButton radioceiling;
        private System.Windows.Forms.RadioButton radio3Button;
        private System.Windows.Forms.RadioButton radio5Button;
        private System.Windows.Forms.RadioButton radio8Button;
        private System.Windows.Forms.RadioButton radio10Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio10;
        private System.Windows.Forms.RadioButton radio8;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

