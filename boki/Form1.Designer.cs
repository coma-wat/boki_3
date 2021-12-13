
namespace boki
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
            this.label1 = new System.Windows.Forms.Label();
            this.debmoBox1 = new System.Windows.Forms.TextBox();
            this.debBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.creBox1 = new System.Windows.Forms.ComboBox();
            this.cremoBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.debBox2 = new System.Windows.Forms.ComboBox();
            this.debmoBox2 = new System.Windows.Forms.TextBox();
            this.debBox3 = new System.Windows.Forms.ComboBox();
            this.debmoBox3 = new System.Windows.Forms.TextBox();
            this.creBox2 = new System.Windows.Forms.ComboBox();
            this.cremoBox2 = new System.Windows.Forms.TextBox();
            this.creBox3 = new System.Windows.Forms.ComboBox();
            this.cremoBox3 = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.acremoTextBox1 = new System.Windows.Forms.TextBox();
            this.adebmoTextBox1 = new System.Windows.Forms.TextBox();
            this.acremoTextBox2 = new System.Windows.Forms.TextBox();
            this.adebmoTextBox2 = new System.Windows.Forms.TextBox();
            this.acremoTextBox3 = new System.Windows.Forms.TextBox();
            this.adebmoTextBox3 = new System.Windows.Forms.TextBox();
            this.adebTextBox1 = new System.Windows.Forms.TextBox();
            this.adebTextBox2 = new System.Windows.Forms.TextBox();
            this.adebTextBox3 = new System.Windows.Forms.TextBox();
            this.acreTextBox1 = new System.Windows.Forms.TextBox();
            this.acreTextBox2 = new System.Windows.Forms.TextBox();
            this.acreTextBox3 = new System.Windows.Forms.TextBox();
            this.marubatuTextBox = new System.Windows.Forms.TextBox();
            this.buntextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.questionCountBox = new System.Windows.Forms.TextBox();
            this.debmo1ClearButton = new System.Windows.Forms.Button();
            this.debmo2ClearButton = new System.Windows.Forms.Button();
            this.debmo3ClearButton = new System.Windows.Forms.Button();
            this.cremo1ClearButton = new System.Windows.Forms.Button();
            this.cremo2ClearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "下記の取引について仕訳しなさい。勘定科目はプルダウンの中から最も適当と思われるものを選び選択すること。";
            // 
            // debmoBox1
            // 
            this.debmoBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debmoBox1.Location = new System.Drawing.Point(228, 282);
            this.debmoBox1.Name = "debmoBox1";
            this.debmoBox1.Size = new System.Drawing.Size(130, 22);
            this.debmoBox1.TabIndex = 2;
            this.debmoBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debmoBox1.Validated += new System.EventHandler(this.DebmoBox1Validated);
            // 
            // debBox1
            // 
            this.debBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debBox1.FormattingEnabled = true;
            this.debBox1.Location = new System.Drawing.Point(37, 281);
            this.debBox1.Name = "debBox1";
            this.debBox1.Size = new System.Drawing.Size(190, 23);
            this.debBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(114, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "借方";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(274, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "金額";
            // 
            // creBox1
            // 
            this.creBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.creBox1.FormattingEnabled = true;
            this.creBox1.Location = new System.Drawing.Point(406, 281);
            this.creBox1.Name = "creBox1";
            this.creBox1.Size = new System.Drawing.Size(190, 23);
            this.creBox1.TabIndex = 7;
            // 
            // cremoBox1
            // 
            this.cremoBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cremoBox1.Location = new System.Drawing.Point(597, 281);
            this.cremoBox1.Name = "cremoBox1";
            this.cremoBox1.Size = new System.Drawing.Size(130, 22);
            this.cremoBox1.TabIndex = 8;
            this.cremoBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cremoBox1.Validated += new System.EventHandler(this.CremoBox1Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(480, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "貸方";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(642, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "金額";
            // 
            // debBox2
            // 
            this.debBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debBox2.FormattingEnabled = true;
            this.debBox2.Location = new System.Drawing.Point(37, 309);
            this.debBox2.Name = "debBox2";
            this.debBox2.Size = new System.Drawing.Size(190, 23);
            this.debBox2.TabIndex = 3;
            // 
            // debmoBox2
            // 
            this.debmoBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debmoBox2.Location = new System.Drawing.Point(228, 309);
            this.debmoBox2.Name = "debmoBox2";
            this.debmoBox2.Size = new System.Drawing.Size(130, 22);
            this.debmoBox2.TabIndex = 4;
            this.debmoBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debmoBox2.Validated += new System.EventHandler(this.DebmoBox2Validated);
            // 
            // debBox3
            // 
            this.debBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debBox3.FormattingEnabled = true;
            this.debBox3.Location = new System.Drawing.Point(37, 337);
            this.debBox3.Name = "debBox3";
            this.debBox3.Size = new System.Drawing.Size(190, 23);
            this.debBox3.TabIndex = 5;
            // 
            // debmoBox3
            // 
            this.debmoBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debmoBox3.Location = new System.Drawing.Point(228, 337);
            this.debmoBox3.Name = "debmoBox3";
            this.debmoBox3.Size = new System.Drawing.Size(130, 22);
            this.debmoBox3.TabIndex = 6;
            this.debmoBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.debmoBox3.Validated += new System.EventHandler(this.DebmoBox3Validated);
            // 
            // creBox2
            // 
            this.creBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.creBox2.FormattingEnabled = true;
            this.creBox2.Location = new System.Drawing.Point(406, 308);
            this.creBox2.Name = "creBox2";
            this.creBox2.Size = new System.Drawing.Size(190, 23);
            this.creBox2.TabIndex = 9;
            // 
            // cremoBox2
            // 
            this.cremoBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cremoBox2.Location = new System.Drawing.Point(597, 309);
            this.cremoBox2.Name = "cremoBox2";
            this.cremoBox2.Size = new System.Drawing.Size(130, 22);
            this.cremoBox2.TabIndex = 10;
            this.cremoBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cremoBox2.Validated += new System.EventHandler(this.CremoBox2Validated);
            // 
            // creBox3
            // 
            this.creBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.creBox3.FormattingEnabled = true;
            this.creBox3.Location = new System.Drawing.Point(406, 336);
            this.creBox3.Name = "creBox3";
            this.creBox3.Size = new System.Drawing.Size(190, 23);
            this.creBox3.TabIndex = 11;
            // 
            // cremoBox3
            // 
            this.cremoBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cremoBox3.Location = new System.Drawing.Point(597, 336);
            this.cremoBox3.Name = "cremoBox3";
            this.cremoBox3.Size = new System.Drawing.Size(130, 22);
            this.cremoBox3.TabIndex = 12;
            this.cremoBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cremoBox3.Validated += new System.EventHandler(this.CremoBox3Validated);
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.LightBlue;
            this.answerButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.answerButton.Location = new System.Drawing.Point(138, 396);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(130, 33);
            this.answerButton.TabIndex = 13;
            this.answerButton.Text = "解答";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.AnswerButtonClicked);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.LightGreen;
            this.nextButton.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(504, 396);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(130, 33);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "次の問題へ";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClicked);
            // 
            // acremoTextBox1
            // 
            this.acremoTextBox1.Enabled = false;
            this.acremoTextBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.acremoTextBox1.Location = new System.Drawing.Point(597, 460);
            this.acremoTextBox1.Name = "acremoTextBox1";
            this.acremoTextBox1.Size = new System.Drawing.Size(130, 22);
            this.acremoTextBox1.TabIndex = 22;
            this.acremoTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // adebmoTextBox1
            // 
            this.adebmoTextBox1.Enabled = false;
            this.adebmoTextBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adebmoTextBox1.Location = new System.Drawing.Point(228, 460);
            this.adebmoTextBox1.Name = "adebmoTextBox1";
            this.adebmoTextBox1.Size = new System.Drawing.Size(130, 22);
            this.adebmoTextBox1.TabIndex = 20;
            this.adebmoTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // acremoTextBox2
            // 
            this.acremoTextBox2.Enabled = false;
            this.acremoTextBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.acremoTextBox2.Location = new System.Drawing.Point(597, 485);
            this.acremoTextBox2.Name = "acremoTextBox2";
            this.acremoTextBox2.Size = new System.Drawing.Size(130, 22);
            this.acremoTextBox2.TabIndex = 25;
            this.acremoTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // adebmoTextBox2
            // 
            this.adebmoTextBox2.Enabled = false;
            this.adebmoTextBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adebmoTextBox2.Location = new System.Drawing.Point(228, 485);
            this.adebmoTextBox2.Name = "adebmoTextBox2";
            this.adebmoTextBox2.Size = new System.Drawing.Size(130, 22);
            this.adebmoTextBox2.TabIndex = 23;
            this.adebmoTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // acremoTextBox3
            // 
            this.acremoTextBox3.Enabled = false;
            this.acremoTextBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.acremoTextBox3.Location = new System.Drawing.Point(597, 510);
            this.acremoTextBox3.Name = "acremoTextBox3";
            this.acremoTextBox3.Size = new System.Drawing.Size(130, 22);
            this.acremoTextBox3.TabIndex = 28;
            this.acremoTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // adebmoTextBox3
            // 
            this.adebmoTextBox3.Enabled = false;
            this.adebmoTextBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adebmoTextBox3.Location = new System.Drawing.Point(228, 511);
            this.adebmoTextBox3.Name = "adebmoTextBox3";
            this.adebmoTextBox3.Size = new System.Drawing.Size(130, 22);
            this.adebmoTextBox3.TabIndex = 26;
            this.adebmoTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // adebTextBox1
            // 
            this.adebTextBox1.Enabled = false;
            this.adebTextBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adebTextBox1.Location = new System.Drawing.Point(37, 460);
            this.adebTextBox1.Name = "adebTextBox1";
            this.adebTextBox1.Size = new System.Drawing.Size(190, 22);
            this.adebTextBox1.TabIndex = 29;
            // 
            // adebTextBox2
            // 
            this.adebTextBox2.Enabled = false;
            this.adebTextBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adebTextBox2.Location = new System.Drawing.Point(37, 485);
            this.adebTextBox2.Name = "adebTextBox2";
            this.adebTextBox2.Size = new System.Drawing.Size(190, 22);
            this.adebTextBox2.TabIndex = 30;
            // 
            // adebTextBox3
            // 
            this.adebTextBox3.Enabled = false;
            this.adebTextBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adebTextBox3.Location = new System.Drawing.Point(37, 511);
            this.adebTextBox3.Name = "adebTextBox3";
            this.adebTextBox3.Size = new System.Drawing.Size(190, 22);
            this.adebTextBox3.TabIndex = 31;
            // 
            // acreTextBox1
            // 
            this.acreTextBox1.Enabled = false;
            this.acreTextBox1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.acreTextBox1.Location = new System.Drawing.Point(406, 460);
            this.acreTextBox1.Name = "acreTextBox1";
            this.acreTextBox1.Size = new System.Drawing.Size(190, 22);
            this.acreTextBox1.TabIndex = 32;
            // 
            // acreTextBox2
            // 
            this.acreTextBox2.Enabled = false;
            this.acreTextBox2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.acreTextBox2.Location = new System.Drawing.Point(406, 485);
            this.acreTextBox2.Name = "acreTextBox2";
            this.acreTextBox2.Size = new System.Drawing.Size(190, 22);
            this.acreTextBox2.TabIndex = 33;
            // 
            // acreTextBox3
            // 
            this.acreTextBox3.Enabled = false;
            this.acreTextBox3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.acreTextBox3.Location = new System.Drawing.Point(406, 510);
            this.acreTextBox3.Name = "acreTextBox3";
            this.acreTextBox3.Size = new System.Drawing.Size(190, 22);
            this.acreTextBox3.TabIndex = 34;
            // 
            // marubatuTextBox
            // 
            this.marubatuTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.marubatuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.marubatuTextBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.marubatuTextBox.Location = new System.Drawing.Point(332, 421);
            this.marubatuTextBox.Name = "marubatuTextBox";
            this.marubatuTextBox.ReadOnly = true;
            this.marubatuTextBox.Size = new System.Drawing.Size(100, 24);
            this.marubatuTextBox.TabIndex = 35;
            this.marubatuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buntextBox
            // 
            this.buntextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buntextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buntextBox.Location = new System.Drawing.Point(40, 80);
            this.buntextBox.Name = "buntextBox";
            this.buntextBox.ReadOnly = true;
            this.buntextBox.Size = new System.Drawing.Size(700, 150);
            this.buntextBox.TabIndex = 36;
            this.buntextBox.Text = "問題文挿入";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(501, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "あなたは今　　　　　　　問目を解いています";
            // 
            // questionCountBox
            // 
            this.questionCountBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.questionCountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionCountBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.questionCountBox.Location = new System.Drawing.Point(569, 10);
            this.questionCountBox.Name = "questionCountBox";
            this.questionCountBox.ReadOnly = true;
            this.questionCountBox.Size = new System.Drawing.Size(52, 19);
            this.questionCountBox.TabIndex = 38;
            this.questionCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // debmo1ClearButton
            // 
            this.debmo1ClearButton.BackColor = System.Drawing.SystemColors.Window;
            this.debmo1ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.debmo1ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.debmo1ClearButton.FlatAppearance.BorderSize = 2;
            this.debmo1ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.debmo1ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.debmo1ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debmo1ClearButton.Location = new System.Drawing.Point(359, 282);
            this.debmo1ClearButton.Name = "debmo1ClearButton";
            this.debmo1ClearButton.Size = new System.Drawing.Size(23, 23);
            this.debmo1ClearButton.TabIndex = 39;
            this.debmo1ClearButton.Text = "×";
            this.debmo1ClearButton.UseVisualStyleBackColor = false;
            this.debmo1ClearButton.Click += new System.EventHandler(this.Debmo1ClearButtonClicked);
            // 
            // debmo2ClearButton
            // 
            this.debmo2ClearButton.BackColor = System.Drawing.SystemColors.Window;
            this.debmo2ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.debmo2ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.debmo2ClearButton.FlatAppearance.BorderSize = 2;
            this.debmo2ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.debmo2ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.debmo2ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debmo2ClearButton.Location = new System.Drawing.Point(359, 309);
            this.debmo2ClearButton.Name = "debmo2ClearButton";
            this.debmo2ClearButton.Size = new System.Drawing.Size(23, 23);
            this.debmo2ClearButton.TabIndex = 40;
            this.debmo2ClearButton.Text = "×";
            this.debmo2ClearButton.UseVisualStyleBackColor = false;
            this.debmo2ClearButton.Click += new System.EventHandler(this.Debmo2ClearButtonClicked);
            // 
            // debmo3ClearButton
            // 
            this.debmo3ClearButton.BackColor = System.Drawing.SystemColors.Window;
            this.debmo3ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.debmo3ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.debmo3ClearButton.FlatAppearance.BorderSize = 2;
            this.debmo3ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.debmo3ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.debmo3ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.debmo3ClearButton.Location = new System.Drawing.Point(359, 337);
            this.debmo3ClearButton.Name = "debmo3ClearButton";
            this.debmo3ClearButton.Size = new System.Drawing.Size(23, 23);
            this.debmo3ClearButton.TabIndex = 41;
            this.debmo3ClearButton.Text = "×";
            this.debmo3ClearButton.UseVisualStyleBackColor = false;
            this.debmo3ClearButton.Click += new System.EventHandler(this.Debmo3ClearButtonClicked);
            // 
            // cremo1ClearButton
            // 
            this.cremo1ClearButton.BackColor = System.Drawing.SystemColors.Window;
            this.cremo1ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cremo1ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cremo1ClearButton.FlatAppearance.BorderSize = 2;
            this.cremo1ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cremo1ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cremo1ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cremo1ClearButton.Location = new System.Drawing.Point(728, 281);
            this.cremo1ClearButton.Name = "cremo1ClearButton";
            this.cremo1ClearButton.Size = new System.Drawing.Size(23, 23);
            this.cremo1ClearButton.TabIndex = 42;
            this.cremo1ClearButton.Text = "×";
            this.cremo1ClearButton.UseVisualStyleBackColor = false;
            this.cremo1ClearButton.Click += new System.EventHandler(this.Cremo1ClearButtonClicked);
            // 
            // cremo2ClearButton
            // 
            this.cremo2ClearButton.BackColor = System.Drawing.SystemColors.Window;
            this.cremo2ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cremo2ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cremo2ClearButton.FlatAppearance.BorderSize = 2;
            this.cremo2ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cremo2ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cremo2ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cremo2ClearButton.Location = new System.Drawing.Point(728, 309);
            this.cremo2ClearButton.Name = "cremo2ClearButton";
            this.cremo2ClearButton.Size = new System.Drawing.Size(23, 23);
            this.cremo2ClearButton.TabIndex = 43;
            this.cremo2ClearButton.Text = "×";
            this.cremo2ClearButton.UseVisualStyleBackColor = false;
            this.cremo2ClearButton.Click += new System.EventHandler(this.Cremo2ClearButtonClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(728, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Cremo3ClearButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cremo2ClearButton);
            this.Controls.Add(this.cremo1ClearButton);
            this.Controls.Add(this.debmo3ClearButton);
            this.Controls.Add(this.debmo2ClearButton);
            this.Controls.Add(this.debmo1ClearButton);
            this.Controls.Add(this.questionCountBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buntextBox);
            this.Controls.Add(this.marubatuTextBox);
            this.Controls.Add(this.acreTextBox3);
            this.Controls.Add(this.acreTextBox2);
            this.Controls.Add(this.acreTextBox1);
            this.Controls.Add(this.adebTextBox3);
            this.Controls.Add(this.adebTextBox2);
            this.Controls.Add(this.adebTextBox1);
            this.Controls.Add(this.acremoTextBox3);
            this.Controls.Add(this.adebmoTextBox3);
            this.Controls.Add(this.acremoTextBox2);
            this.Controls.Add(this.adebmoTextBox2);
            this.Controls.Add(this.acremoTextBox1);
            this.Controls.Add(this.adebmoTextBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.creBox3);
            this.Controls.Add(this.cremoBox3);
            this.Controls.Add(this.creBox2);
            this.Controls.Add(this.cremoBox2);
            this.Controls.Add(this.debBox3);
            this.Controls.Add(this.debmoBox3);
            this.Controls.Add(this.debBox2);
            this.Controls.Add(this.debmoBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cremoBox1);
            this.Controls.Add(this.creBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.debBox1);
            this.Controls.Add(this.debmoBox1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "簿記3級問題";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox debmoBox1;
        private System.Windows.Forms.ComboBox debBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox creBox1;
        private System.Windows.Forms.TextBox cremoBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox debBox2;
        private System.Windows.Forms.TextBox debmoBox2;
        private System.Windows.Forms.ComboBox debBox3;
        private System.Windows.Forms.TextBox debmoBox3;
        private System.Windows.Forms.ComboBox creBox2;
        private System.Windows.Forms.TextBox cremoBox2;
        private System.Windows.Forms.ComboBox creBox3;
        private System.Windows.Forms.TextBox cremoBox3;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox acremoTextBox1;
        private System.Windows.Forms.TextBox adebmoTextBox1;
        private System.Windows.Forms.TextBox acremoTextBox2;
        private System.Windows.Forms.TextBox adebmoTextBox2;
        private System.Windows.Forms.TextBox acremoTextBox3;
        private System.Windows.Forms.TextBox adebmoTextBox3;
        private System.Windows.Forms.TextBox adebTextBox1;
        private System.Windows.Forms.TextBox adebTextBox2;
        private System.Windows.Forms.TextBox adebTextBox3;
        private System.Windows.Forms.TextBox acreTextBox1;
        private System.Windows.Forms.TextBox acreTextBox2;
        private System.Windows.Forms.TextBox acreTextBox3;
        private System.Windows.Forms.TextBox marubatuTextBox;
        private System.Windows.Forms.RichTextBox buntextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox questionCountBox;
        private System.Windows.Forms.Button debmo1ClearButton;
        private System.Windows.Forms.Button debmo2ClearButton;
        private System.Windows.Forms.Button debmo3ClearButton;
        private System.Windows.Forms.Button cremo1ClearButton;
        private System.Windows.Forms.Button cremo2ClearButton;
        private System.Windows.Forms.Button button1;
    }
}

