using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wardrobe
{
    public partial class Form2 : Form
    {
        public string FilePath { get; set; } = null;
        public string type { get; set; } = null;
        public string color { get; set; } = null;
        public string season { get; set; } = null;
        public string style { get; set; } = null;
        public string name { get; set; } = null;
        //public DateTime date { get; set; }
        public string place { get; set; } = null;
        public string size { get; set; } = null;
        public string date { get; set; } = null;

        public event EventHandler<EventArgs> LoadF2;
        public event EventHandler<EventArgs> Save_clothes;
        public Form1 MainForm { get; set; }
        public Form2()
        {
            InitializeComponent();
            //date = dateTimePicker1.Value.Date;
            date = dateTimePicker1.Value.ToString("dd.MM.yyyy");
        }

        private void LoadForm2(object sender, EventArgs e)
        {
            try
            {
                LoadF2?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetSeason(string s)
        {
            comboBox4.Items.Add(s);
        }
        public void SetStyle(string s)
        {
            comboBox2.Items.Add(s);
        }
        public void SetType(string s)
        {
            comboBox1.Items.Add(s);
        }
        public void SetColor(string s)
        {
            comboBox3.Items.Add(s);
        }

        private void addPhoto(object sender, EventArgs e)
        {
            MainForm.add_clothe = this;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(FilePath);
                }
            }
        }

        private void saveClothe(object sender, EventArgs e)
        {
            MainForm.add_clothe = this;
            if (FilePath != null && name != null && type != null && style != null && season != null && color != null)
            {
                Save_clothes?.Invoke(this, EventArgs.Empty);
                FilePath = null;
                this.Close();
                MessageBox.Show("одежда добавлена");
            }
            else
            {
                MessageBox.Show("ПЕРЕД ДОБАВЛЕНИЕМ ОБЯЗАТЕЛЬНО:\n\nзагрузить фото\nввести название\n тип\n стиль\n цвет\n сезон");
            }

        }

        private void textCanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void selectedType(object sender, EventArgs e)
        {
            type = comboBox1.SelectedItem.ToString();
        }

        private void selectedStyle(object sender, EventArgs e)
        {
            style = comboBox2.SelectedItem.ToString();
        }

        private void selecteColor(object sender, EventArgs e)
        {
            color = comboBox3.SelectedItem.ToString();
        }

        private void selecteSeason(object sender, EventArgs e)
        {
            season = comboBox4.SelectedItem.ToString();
        }

        private void dateChange(object sender, EventArgs e)
        {
            //date = dateTimePicker1.Value.Date;
            date = dateTimePicker1.Value.ToString("dd.MM.yyyy");
        }
    }
}
