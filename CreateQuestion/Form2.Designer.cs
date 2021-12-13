
namespace CreateQuestion
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.csvSaveButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.choiceBox1 = new System.Windows.Forms.TextBox();
            this.choiceBox2 = new System.Windows.Forms.TextBox();
            this.choiceBox3 = new System.Windows.Forms.TextBox();
            this.choiceBox4 = new System.Windows.Forms.TextBox();
            this.choiceBox5 = new System.Windows.Forms.TextBox();
            this.choiceBox6 = new System.Windows.Forms.TextBox();
            this.choiceBox7 = new System.Windows.Forms.TextBox();
            this.qDebBox1 = new System.Windows.Forms.TextBox();
            this.qDebmoBox1 = new System.Windows.Forms.TextBox();
            this.qCreBox1 = new System.Windows.Forms.TextBox();
            this.qCremoBox1 = new System.Windows.Forms.TextBox();
            this.qCremoBox2 = new System.Windows.Forms.TextBox();
            this.qCreBox2 = new System.Windows.Forms.TextBox();
            this.qDebmoBox2 = new System.Windows.Forms.TextBox();
            this.qDebBox2 = new System.Windows.Forms.TextBox();
            this.qCremoBox3 = new System.Windows.Forms.TextBox();
            this.qCreBox3 = new System.Windows.Forms.TextBox();
            this.qDebmoBox3 = new System.Windows.Forms.TextBox();
            this.qDebBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1DataError);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderClick);
            // 
            // csvSaveButton
            // 
            this.csvSaveButton.BackColor = System.Drawing.Color.LightCoral;
            this.csvSaveButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.csvSaveButton.Location = new System.Drawing.Point(1003, 605);
            this.csvSaveButton.Name = "csvSaveButton";
            this.csvSaveButton.Size = new System.Drawing.Size(147, 36);
            this.csvSaveButton.TabIndex = 120;
            this.csvSaveButton.Text = "csvファイル保存";
            this.csvSaveButton.UseVisualStyleBackColor = false;
            this.csvSaveButton.Click += new System.EventHandler(this.CsvSaveButtonClicked);
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.idBox.Location = new System.Drawing.Point(110, 360);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(180, 21);
            this.idBox.TabIndex = 1;
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.questionBox.Location = new System.Drawing.Point(412, 363);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(700, 100);
            this.questionBox.TabIndex = 2;
            this.questionBox.Validated += new System.EventHandler(this.QuestionBoxValidated);
            // 
            // choiceBox1
            // 
            this.choiceBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choiceBox1.Location = new System.Drawing.Point(110, 420);
            this.choiceBox1.Name = "choiceBox1";
            this.choiceBox1.Size = new System.Drawing.Size(180, 21);
            this.choiceBox1.TabIndex = 3;
            this.choiceBox1.Validated += new System.EventHandler(this.ChoiceBox1Validated);
            // 
            // choiceBox2
            // 
            this.choiceBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choiceBox2.Location = new System.Drawing.Point(110, 447);
            this.choiceBox2.Name = "choiceBox2";
            this.choiceBox2.Size = new System.Drawing.Size(180, 21);
            this.choiceBox2.TabIndex = 4;
            this.choiceBox2.Validated += new System.EventHandler(this.ChoiceBox2Validated);
            // 
            // choiceBox3
            // 
            this.choiceBox3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choiceBox3.Location = new System.Drawing.Point(110, 474);
            this.choiceBox3.Name = "choiceBox3";
            this.choiceBox3.Size = new System.Drawing.Size(180, 21);
            this.choiceBox3.TabIndex = 5;
            this.choiceBox3.Validated += new System.EventHandler(this.ChoiceBox3Validated);
            // 
            // choiceBox4
            // 
            this.choiceBox4.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choiceBox4.Location = new System.Drawing.Point(110, 501);
            this.choiceBox4.Name = "choiceBox4";
            this.choiceBox4.Size = new System.Drawing.Size(180, 21);
            this.choiceBox4.TabIndex = 6;
            this.choiceBox4.Validated += new System.EventHandler(this.ChoiceBox4Validated);
            // 
            // choiceBox5
            // 
            this.choiceBox5.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choiceBox5.Location = new System.Drawing.Point(110, 528);
            this.choiceBox5.Name = "choiceBox5";
            this.choiceBox5.Size = new System.Drawing.Size(180, 21);
            this.choiceBox5.TabIndex = 7;
            this.choiceBox5.Validated += new System.EventHandler(this.ChoiceBox5Validated);
            // 
            // choiceBox6
            // 
            this.choiceBox6.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choiceBox6.Location = new System.Drawing.Point(110, 555);
            this.choiceBox6.Name = "choiceBox6";
            this.choiceBox6.Size = new System.Drawing.Size(180, 21);
            this.choiceBox6.TabIndex = 8;
            this.choiceBox6.Validated += new System.EventHandler(this.ChoiceBox6Validated);
            // 
            // choiceBox7
            // 
            this.choiceBox7.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choiceBox7.Location = new System.Drawing.Point(110, 582);
            this.choiceBox7.Name = "choiceBox7";
            this.choiceBox7.Size = new System.Drawing.Size(180, 21);
            this.choiceBox7.TabIndex = 9;
            this.choiceBox7.Validated += new System.EventHandler(this.ChoiceBox7Validated);
            // 
            // qDebBox1
            // 
            this.qDebBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qDebBox1.Location = new System.Drawing.Point(412, 501);
            this.qDebBox1.Name = "qDebBox1";
            this.qDebBox1.Size = new System.Drawing.Size(180, 21);
            this.qDebBox1.TabIndex = 108;
            this.qDebBox1.Validated += new System.EventHandler(this.QDebBox1Validated);
            // 
            // qDebmoBox1
            // 
            this.qDebmoBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qDebmoBox1.Location = new System.Drawing.Point(598, 501);
            this.qDebmoBox1.Name = "qDebmoBox1";
            this.qDebmoBox1.Size = new System.Drawing.Size(180, 21);
            this.qDebmoBox1.TabIndex = 109;
            this.qDebmoBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qDebmoBox1.TextChanged += new System.EventHandler(this.QDebmoBox1TextChanged);
            this.qDebmoBox1.Validated += new System.EventHandler(this.QDebmoBox1Validated);
            // 
            // qCreBox1
            // 
            this.qCreBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qCreBox1.Location = new System.Drawing.Point(784, 501);
            this.qCreBox1.Name = "qCreBox1";
            this.qCreBox1.Size = new System.Drawing.Size(180, 21);
            this.qCreBox1.TabIndex = 110;
            this.qCreBox1.Validated += new System.EventHandler(this.QCreBox1Validated);
            // 
            // qCremoBox1
            // 
            this.qCremoBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qCremoBox1.Location = new System.Drawing.Point(970, 501);
            this.qCremoBox1.Name = "qCremoBox1";
            this.qCremoBox1.Size = new System.Drawing.Size(180, 21);
            this.qCremoBox1.TabIndex = 111;
            this.qCremoBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qCremoBox1.TextChanged += new System.EventHandler(this.QCremoBox1TextChanged);
            this.qCremoBox1.Validated += new System.EventHandler(this.QCremoBox1Validated);
            // 
            // qCremoBox2
            // 
            this.qCremoBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qCremoBox2.Location = new System.Drawing.Point(970, 528);
            this.qCremoBox2.Name = "qCremoBox2";
            this.qCremoBox2.Size = new System.Drawing.Size(180, 21);
            this.qCremoBox2.TabIndex = 115;
            this.qCremoBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qCremoBox2.TextChanged += new System.EventHandler(this.QCremoBox2TextChanged);
            this.qCremoBox2.Validated += new System.EventHandler(this.QCremoBox2Validated);
            // 
            // qCreBox2
            // 
            this.qCreBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qCreBox2.Location = new System.Drawing.Point(784, 528);
            this.qCreBox2.Name = "qCreBox2";
            this.qCreBox2.Size = new System.Drawing.Size(180, 21);
            this.qCreBox2.TabIndex = 114;
            this.qCreBox2.Validated += new System.EventHandler(this.QCreBox2Validated);
            // 
            // qDebmoBox2
            // 
            this.qDebmoBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qDebmoBox2.Location = new System.Drawing.Point(598, 528);
            this.qDebmoBox2.Name = "qDebmoBox2";
            this.qDebmoBox2.Size = new System.Drawing.Size(180, 21);
            this.qDebmoBox2.TabIndex = 113;
            this.qDebmoBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qDebmoBox2.TextChanged += new System.EventHandler(this.QDebmoBox2TextChanged);
            this.qDebmoBox2.Validated += new System.EventHandler(this.QDebmoBox2Validated);
            // 
            // qDebBox2
            // 
            this.qDebBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qDebBox2.Location = new System.Drawing.Point(412, 528);
            this.qDebBox2.Name = "qDebBox2";
            this.qDebBox2.Size = new System.Drawing.Size(180, 21);
            this.qDebBox2.TabIndex = 112;
            this.qDebBox2.Validated += new System.EventHandler(this.QDebBox2Validated);
            // 
            // qCremoBox3
            // 
            this.qCremoBox3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qCremoBox3.Location = new System.Drawing.Point(970, 555);
            this.qCremoBox3.Name = "qCremoBox3";
            this.qCremoBox3.Size = new System.Drawing.Size(180, 21);
            this.qCremoBox3.TabIndex = 119;
            this.qCremoBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qCremoBox3.TextChanged += new System.EventHandler(this.QCremoBox3TextChanged);
            this.qCremoBox3.Validated += new System.EventHandler(this.QCremoBox3Validated);
            // 
            // qCreBox3
            // 
            this.qCreBox3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qCreBox3.Location = new System.Drawing.Point(784, 555);
            this.qCreBox3.Name = "qCreBox3";
            this.qCreBox3.Size = new System.Drawing.Size(180, 21);
            this.qCreBox3.TabIndex = 118;
            this.qCreBox3.Validated += new System.EventHandler(this.QCreBox3Validated);
            // 
            // qDebmoBox3
            // 
            this.qDebmoBox3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qDebmoBox3.Location = new System.Drawing.Point(598, 555);
            this.qDebmoBox3.Name = "qDebmoBox3";
            this.qDebmoBox3.Size = new System.Drawing.Size(180, 21);
            this.qDebmoBox3.TabIndex = 117;
            this.qDebmoBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qDebmoBox3.TextChanged += new System.EventHandler(this.QDebmoBox3TextChanged);
            this.qDebmoBox3.Validated += new System.EventHandler(this.QDebmoBox3Validated);
            // 
            // qDebBox3
            // 
            this.qDebBox3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.qDebBox3.Location = new System.Drawing.Point(412, 555);
            this.qDebBox3.Name = "qDebBox3";
            this.qDebBox3.Size = new System.Drawing.Size(180, 21);
            this.qDebBox3.TabIndex = 116;
            this.qDebBox3.Validated += new System.EventHandler(this.QDebBox3Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(107, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 120;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(107, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 121;
            this.label2.Text = "選択肢";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(81, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 122;
            this.label3.Text = "①";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(81, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 123;
            this.label4.Text = "②";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(81, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 124;
            this.label5.Text = "③";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(81, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 125;
            this.label6.Text = "④";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(81, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 126;
            this.label7.Text = "⑤";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(81, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 127;
            this.label8.Text = "⑥";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(81, 583);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 128;
            this.label9.Text = "⑦";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(409, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 129;
            this.label10.Text = "問題文";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(409, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 130;
            this.label11.Text = "借方";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(595, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 15);
            this.label12.TabIndex = 131;
            this.label12.Text = "借方金額";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(781, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 132;
            this.label13.Text = "貸方";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(967, 483);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 133;
            this.label14.Text = "貸方金額";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(383, 502);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 15);
            this.label15.TabIndex = 134;
            this.label15.Text = "①";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(383, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 15);
            this.label16.TabIndex = 135;
            this.label16.Text = "②";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(383, 556);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 15);
            this.label17.TabIndex = 136;
            this.label17.Text = "③";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qCremoBox3);
            this.Controls.Add(this.qCreBox3);
            this.Controls.Add(this.qDebmoBox3);
            this.Controls.Add(this.qDebBox3);
            this.Controls.Add(this.qCremoBox2);
            this.Controls.Add(this.qCreBox2);
            this.Controls.Add(this.qDebmoBox2);
            this.Controls.Add(this.qDebBox2);
            this.Controls.Add(this.qCremoBox1);
            this.Controls.Add(this.qCreBox1);
            this.Controls.Add(this.qDebmoBox1);
            this.Controls.Add(this.qDebBox1);
            this.Controls.Add(this.choiceBox7);
            this.Controls.Add(this.choiceBox6);
            this.Controls.Add(this.choiceBox5);
            this.Controls.Add(this.choiceBox4);
            this.Controls.Add(this.choiceBox3);
            this.Controls.Add(this.choiceBox2);
            this.Controls.Add(this.choiceBox1);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.csvSaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "問題作成フォーム";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button csvSaveButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.TextBox choiceBox1;
        private System.Windows.Forms.TextBox choiceBox2;
        private System.Windows.Forms.TextBox choiceBox3;
        private System.Windows.Forms.TextBox choiceBox4;
        private System.Windows.Forms.TextBox choiceBox5;
        private System.Windows.Forms.TextBox choiceBox6;
        private System.Windows.Forms.TextBox choiceBox7;
        private System.Windows.Forms.TextBox qDebBox1;
        private System.Windows.Forms.TextBox qDebmoBox1;
        private System.Windows.Forms.TextBox qCreBox1;
        private System.Windows.Forms.TextBox qCremoBox1;
        private System.Windows.Forms.TextBox qCremoBox2;
        private System.Windows.Forms.TextBox qCreBox2;
        private System.Windows.Forms.TextBox qDebmoBox2;
        private System.Windows.Forms.TextBox qDebBox2;
        private System.Windows.Forms.TextBox qCremoBox3;
        private System.Windows.Forms.TextBox qCreBox3;
        private System.Windows.Forms.TextBox qDebmoBox3;
        private System.Windows.Forms.TextBox qDebBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

