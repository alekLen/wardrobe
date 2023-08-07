namespace wardrobe
{
    partial class Form3
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
            textBoxName = new TextBox();
            pictureBox1 = new PictureBox();
            textBoxStyle = new TextBox();
            textBoxColor = new TextBox();
            textBoxSeason = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxPlace = new TextBox();
            textBoxSize = new TextBox();
            label6 = new Label();
            textBoxDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(7, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(392, 47);
            textBoxName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(405, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(663, 653);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxStyle
            // 
            textBoxStyle.Enabled = false;
            textBoxStyle.Location = new Point(83, 65);
            textBoxStyle.Name = "textBoxStyle";
            textBoxStyle.Size = new Size(271, 27);
            textBoxStyle.TabIndex = 2;
            // 
            // textBoxColor
            // 
            textBoxColor.Enabled = false;
            textBoxColor.Location = new Point(83, 99);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(271, 27);
            textBoxColor.TabIndex = 3;
            // 
            // textBoxSeason
            // 
            textBoxSeason.Enabled = false;
            textBoxSeason.Location = new Point(83, 132);
            textBoxSeason.Name = "textBoxSeason";
            textBoxSeason.Size = new Size(271, 27);
            textBoxSeason.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(63, 495);
            button1.Name = "button1";
            button1.Size = new Size(232, 43);
            button1.TabIndex = 5;
            button1.Text = "добвить в комплект";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 68);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "стиль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 106);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 7;
            label2.Text = "цвет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 139);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "сезон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 168);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 10;
            label4.Text = "дата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 201);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 11;
            label5.Text = "магазин";
            // 
            // textBoxPlace
            // 
            textBoxPlace.Enabled = false;
            textBoxPlace.Location = new Point(83, 198);
            textBoxPlace.Name = "textBoxPlace";
            textBoxPlace.Size = new Size(271, 27);
            textBoxPlace.TabIndex = 12;
            // 
            // textBoxSize
            // 
            textBoxSize.Enabled = false;
            textBoxSize.Location = new Point(229, 231);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(125, 27);
            textBoxSize.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 234);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 14;
            label6.Text = "размер";
            // 
            // textBoxDate
            // 
            textBoxDate.Enabled = false;
            textBoxDate.Location = new Point(187, 165);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(167, 27);
            textBoxDate.TabIndex = 15;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 688);
            Controls.Add(textBoxDate);
            Controls.Add(label6);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxPlace);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxSeason);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxStyle);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxName);
            Name = "Form3";
            Text = "Предмет одежды";
            Load += LoadFm3;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private PictureBox pictureBox1;
        private TextBox textBoxStyle;
        private TextBox textBoxColor;
        private TextBox textBoxSeason;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPlace;
        private TextBox textBoxSize;
        private Label label6;
        private TextBox textBoxDate;
    }
}