﻿namespace wardrobe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            стильОдеждыToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem1 = new ToolStripMenuItem();
            сезонToolStripMenuItem = new ToolStripMenuItem();
            цветToolStripMenuItem = new ToolStripMenuItem();
            альбомToolStripMenuItem = new ToolStripMenuItem();
            добавитьодеждуToolStripMenuItem = new ToolStripMenuItem();
            просмотрToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listView2 = new ListView();
            listView4 = new ListView();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView5 = new ListView();
            label4 = new Label();
            button5 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            listView3 = new ListView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AccessibleRole = AccessibleRole.ScrollBar;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(227, 378);
            listView1.Name = "listView1";
            listView1.Size = new Size(314, 304);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += Load_see_formUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(227, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { редактироватьToolStripMenuItem, добавитьодеждуToolStripMenuItem, просмотрToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1702, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { стильОдеждыToolStripMenuItem, сезонToolStripMenuItem, цветToolStripMenuItem, альбомToolStripMenuItem });
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(126, 24);
            редактироватьToolStripMenuItem.Text = "редактировать";
            // 
            // стильОдеждыToolStripMenuItem
            // 
            стильОдеждыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem, редактироватьToolStripMenuItem1 });
            стильОдеждыToolStripMenuItem.Name = "стильОдеждыToolStripMenuItem";
            стильОдеждыToolStripMenuItem.Size = new Size(210, 26);
            стильОдеждыToolStripMenuItem.Text = "характеристики";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(132, 26);
            добавитьToolStripMenuItem.Text = "стиль";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(132, 26);
            удалитьToolStripMenuItem.Text = "сезон";
            // 
            // редактироватьToolStripMenuItem1
            // 
            редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            редактироватьToolStripMenuItem1.Size = new Size(132, 26);
            редактироватьToolStripMenuItem1.Text = "цвет";
            // 
            // сезонToolStripMenuItem
            // 
            сезонToolStripMenuItem.Name = "сезонToolStripMenuItem";
            сезонToolStripMenuItem.Size = new Size(210, 26);
            сезонToolStripMenuItem.Text = "предмет одежды";
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new Size(210, 26);
            цветToolStripMenuItem.Text = "комплект";
            // 
            // альбомToolStripMenuItem
            // 
            альбомToolStripMenuItem.Name = "альбомToolStripMenuItem";
            альбомToolStripMenuItem.Size = new Size(210, 26);
            альбомToolStripMenuItem.Text = "альбом";
            // 
            // добавитьодеждуToolStripMenuItem
            // 
            добавитьодеждуToolStripMenuItem.Name = "добавитьодеждуToolStripMenuItem";
            добавитьодеждуToolStripMenuItem.Size = new Size(145, 24);
            добавитьодеждуToolStripMenuItem.Text = "добавить_одежду";
            добавитьодеждуToolStripMenuItem.Click += Add_Form;
            // 
            // просмотрToolStripMenuItem
            // 
            просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            просмотрToolStripMenuItem.Size = new Size(168, 24);
            просмотрToolStripMenuItem.Text = "просмотр_альбомов";
            // 
            // button1
            // 
            button1.Location = new Point(357, 699);
            button1.Name = "button1";
            button1.Size = new Size(261, 29);
            button1.TabIndex = 3;
            button1.Text = "цветовая статистика";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(699, 699);
            button2.Name = "button2";
            button2.Size = new Size(261, 29);
            button2.TabIndex = 4;
            button2.Text = "статистика видов одежды";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1018, 699);
            button3.Name = "button3";
            button3.Size = new Size(261, 29);
            button3.TabIndex = 5;
            button3.Text = "статистика стилей";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(261, 348);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 24);
            listBox1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(573, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 272);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(922, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(314, 272);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(1270, 38);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(314, 272);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(614, 348);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(199, 24);
            listBox2.TabIndex = 10;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(952, 348);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(210, 24);
            listBox3.TabIndex = 11;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(1314, 348);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(190, 24);
            listBox4.TabIndex = 12;
            // 
            // listView2
            // 
            listView2.GridLines = true;
            listView2.Location = new Point(573, 378);
            listView2.Name = "listView2";
            listView2.Size = new Size(314, 304);
            listView2.TabIndex = 13;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += Load_see_formBottom;
            // 
            // listView4
            // 
            listView4.GridLines = true;
            listView4.Location = new Point(1270, 378);
            listView4.Name = "listView4";
            listView4.Size = new Size(314, 304);
            listView4.TabIndex = 15;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            listView4.SelectedIndexChanged += Load_see_formShoe;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(486, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 16;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(849, 355);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 17;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(1198, 355);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 18;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(1536, 355);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 19;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1596, 287);
            button4.Name = "button4";
            button4.Size = new Size(94, 113);
            button4.TabIndex = 20;
            button4.Text = "добавить комплект";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 84);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 22;
            label1.Text = "цвет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 146);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 25;
            label2.Text = "сезон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 210);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 26;
            label3.Text = "стиль";
            // 
            // listView5
            // 
            listView5.Location = new Point(32, 336);
            listView5.Name = "listView5";
            listView5.Size = new Size(148, 124);
            listView5.TabIndex = 27;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 313);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 28;
            label4.Text = "фильтр";
            // 
            // button5
            // 
            button5.Location = new Point(35, 531);
            button5.Name = "button5";
            button5.Size = new Size(145, 29);
            button5.TabIndex = 29;
            button5.Text = "сбросить фильтр";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(32, 477);
            button6.Name = "button6";
            button6.Size = new Size(148, 29);
            button6.TabIndex = 30;
            button6.Text = "фильтровать";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 31;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(32, 169);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 32;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(31, 233);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 33;
            // 
            // listView3
            // 
            listView3.GridLines = true;
            listView3.Location = new Point(922, 378);
            listView3.Name = "listView3";
            listView3.Size = new Size(314, 304);
            listView3.TabIndex = 14;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            listView3.SelectedIndexChanged += Load_see_formSuit;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 313);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 34;
            label5.Text = "верх";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(708, 313);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 35;
            label6.Text = "низ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(999, 313);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 36;
            label7.Text = "платье/костюм";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1366, 313);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 37;
            label8.Text = "обувь";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1702, 740);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(listView5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(listView4);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Гардероб";
            Load += LoadForm;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem просмотрToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem стильОдеждыToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem1;
        private ToolStripMenuItem сезонToolStripMenuItem;
        private ToolStripMenuItem цветToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListView listView2;
        private ListView listView4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView5;
        private Label label4;
        private Button button5;
        private ToolStripMenuItem альбомToolStripMenuItem;
        private Button button6;
        private ToolStripMenuItem добавитьодеждуToolStripMenuItem;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ListView listView3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}