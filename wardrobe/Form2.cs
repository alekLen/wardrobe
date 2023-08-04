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
        public string FilePath { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public string season { get; set; }
        public string style { get; set; }

        public event EventHandler<EventArgs> LoadF2;
        public Form1 MainForm { get; set; }
        public Form2()
        {
            InitializeComponent();

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
            listBox4.Items.Add(s);
        }
        public void SetStyle(string s)
        {
            listBox2.Items.Add(s);
        }
        public void SetType(string s)
        {
            listBox1.Items.Add(s);
        }
        public void SetColor(string s)
        {
            listBox3.Items.Add(s);
        }

        private void addPhoto(object sender, EventArgs e)
        {
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

       
    }
}
