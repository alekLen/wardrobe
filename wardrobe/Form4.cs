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
        public event EventHandler<EventArgs> LoadShowStyle;
        public event EventHandler<EventArgs> LoadShowSeason;
        public event EventHandler<EventArgs> LoadShowColor;
        public event EventHandler<EventArgs> AddStyle;
        public event EventHandler<EventArgs> AddSeason;
        public event EventHandler<EventArgs> AddColor;
        System.Windows.Forms.ListBox listbox;
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
                CreateList();
                if (category == "style")
                {
                    label1.Text = "стили";
                    label2.Text = "новый стиль";
                    LoadShowStyle?.Invoke(this, EventArgs.Empty);
                    button1.Click += addStyle;
                }
                if (category == "season")
                {
                    label1.Text = "сезоны";
                    label2.Text = "новый сезон";
                    LoadShowSeason?.Invoke(this, EventArgs.Empty);
                    button1.Click += addSeason;
                }
                if (category == "color")
                {
                    label1.Text = "цвета";
                    label2.Text = "новый цвет";
                    LoadShowColor?.Invoke(this, EventArgs.Empty);
                    button1.Click += addColor;
                }
            }
            if (category == "style" && action != "add")
            {
                label1.Text = "стили";
                LoadEditStyle?.Invoke(this, EventArgs.Empty);
            }
            if (category == "season" && action != "add")
            {
                label1.Text = "сезоны";
                LoadEditSeason?.Invoke(this, EventArgs.Empty);
            }
            if (category == "color" && action != "add")
            {
                label1.Text = "цвета";
                LoadEditColor?.Invoke(this, EventArgs.Empty);
            }
            if (action != "add")
                comboBox1.SelectedIndex = 0;
        }
        public void SetCategory(string s)
        {
            comboBox1.Items.Add(s);
        }
        public void ShowCategory(string s)
        {
            listbox.Items.Add(s);
        }
        private void selected(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
        private void CreateList()
        {
            listbox = new ListBox();
            listbox.Location = comboBox1.Location;
            this.Controls.Remove(comboBox1);
            this.Controls.Add(listbox);
        }
        private void addStyle(object sender, EventArgs e)
        {
            AddStyle?.Invoke(this, EventArgs.Empty);
        }
        private void addSeason(object sender, EventArgs e)
        {
            AddSeason?.Invoke(this, EventArgs.Empty);
        }
        private void addColor(object sender, EventArgs e)
        {
            AddColor?.Invoke(this, EventArgs.Empty);
        }
    }
}
