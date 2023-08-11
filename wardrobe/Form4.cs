using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace wardrobe
{
    public partial class Form4 : Form
    {
        public string category { get; set; }
        public string action { get; set; }
        public event EventHandler<EventArgs> LoadEditStyle;
        public event EventHandler<EventArgs> LoadEditColor;
        public event EventHandler<EventArgs> LoadEditSeason;
        public Form1 MainForm { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void Load_Form4(object sender, EventArgs e)
        {
            if (action == "edit")
            {
                this.Text = "редактирование";
                textBox1.Enabled = true;
                button1.Text = "изменить";
            }
            if (action == "delete")
            {
                this.Text = "удаление";
                textBox1.Enabled = false;
                button1.Text = "удалить";
            }
            if (action == "add")
            {
                this.Text = "добавление";
                textBox1.Enabled = true;
                button1.Text = "добавить";
            }
            if (category == "style")
            {
                label1.Text = "стили";
                LoadEditStyle?.Invoke(this, EventArgs.Empty);
            }
            if (category == "season")
            {
                label1.Text = "сезоны";
                LoadEditSeason?.Invoke(this, EventArgs.Empty);
            }
            if (category == "color")
            {
                label1.Text = "цвета";
                LoadEditColor?.Invoke(this, EventArgs.Empty);
            }

        }
        public void SetCategory(string s)
        {
            comboBox1.Items.Add(s);
        }

        private void selected(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
