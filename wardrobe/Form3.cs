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
        public event EventHandler<EventArgs> AddToCom;
        public event EventHandler<EventArgs> DeleteItem;
        public int cId;
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
                cId = MainForm.setId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToComplectBox(object sender, EventArgs e)
        {
            AddToCom?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void edit_item(object sender, EventArgs e)
        {

        }

        private void delete(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("вы действительно хотите удалить\n " +textBoxName.Text+" из гардероба", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteItem?.Invoke(this, EventArgs.Empty);
                this.Close();
                MessageBox.Show("одежда  удалена");
            }
        }
    }
}
