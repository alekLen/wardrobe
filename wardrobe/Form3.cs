using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wardrobe
{
    public partial class Form3 : Form
    {
        public Form1 MainForm { get; set; }
        public event EventHandler<EventArgs> LoadF3;
        public Form3()
        {
            InitializeComponent();
        }

        public void SetSeason(string s)
        {
            textBoxSeason.Text = s;
        }
        public void SetStyle(string s)
        {
            textBoxStyle.Text = s;
        }
        public void SetType(string s)
        {
            textBoxDate.Text = s;
        }
        public void SetColor(string s)
        {
            textBoxColor.Text = s;
        }
        public void SetName(string s)
        {
            textBoxName.Text = s;
        }
        public void SetPlace(string s)
        {
            textBoxPlace.Text = s;
        }
        public void SetDate(string s)
        {
            textBoxDate.Text = s;
        }
        public void SetSize(string s)
        {
            textBoxSize.Text = s;
        }
        public void SetPhoto(string s)
        {
            pictureBox1.Image = Image.FromFile(s);
        }

        private void LoadFm3(object sender, EventArgs e)
        {

            try
            {
                LoadF3?.Invoke(this, EventArgs.Empty);              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
