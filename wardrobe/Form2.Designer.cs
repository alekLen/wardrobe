namespace wardrobe
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 130);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "*тип одежды";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 199);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "*стиль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 272);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "*цвет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 335);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "*сезон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 41);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 4;
            label5.Text = "*наименование одежды";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(457, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textCanged;
            // 
            // button1
            // 
            button1.Location = new Point(311, 54);
            button1.Name = "button1";
            button1.Size = new Size(94, 70);
            button1.TabIndex = 11;
            button1.Text = "загрузить фото";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addPhoto;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 150);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 13;
            label6.Text = "дата покупки";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 318);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 27);
            textBox3.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 295);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 16;
            label7.Text = "место покупки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 226);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 17;
            label8.Text = "размер";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(212, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(562, 378);
            button2.Name = "button2";
            button2.Size = new Size(214, 29);
            button2.TabIndex = 19;
            button2.Text = "добавить одежду";
            button2.UseVisualStyleBackColor = true;
            button2.Click += saveClothe;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(38, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += selectedType;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(38, 218);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedIndexChanged += selectedStyle;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(38, 295);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 22;
            comboBox3.SelectedIndexChanged += selecteColor;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(38, 358);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 23;
            comboBox4.SelectedIndexChanged += selecteSeason;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(291, 54);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 24;
            label9.Text = "*";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 440);
            Controls.Add(label9);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "добавление одежды";
            Load += LoadForm2;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label9;
    }
}