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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(53, 44);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(234, 27);
            textBoxName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(327, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 415);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxStyle
            // 
            textBoxStyle.Location = new Point(55, 98);
            textBoxStyle.Name = "textBoxStyle";
            textBoxStyle.Size = new Size(232, 27);
            textBoxStyle.TabIndex = 2;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(55, 159);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(232, 27);
            textBoxColor.TabIndex = 3;
            // 
            // textBoxSeason
            // 
            textBoxSeason.Location = new Point(55, 220);
            textBoxSeason.Name = "textBoxSeason";
            textBoxSeason.Size = new Size(232, 27);
            textBoxSeason.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(55, 390);
            button1.Name = "button1";
            button1.Size = new Size(232, 29);
            button1.TabIndex = 5;
            button1.Text = "добвить в комплект";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(button1);
            Controls.Add(textBoxSeason);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxStyle);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxName);
            Name = "Form3";
            Text = "Предмет одежды";
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
    }
}