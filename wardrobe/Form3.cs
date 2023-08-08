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
        public event EventHandler<EventArgs> EditItem;
        public event EventHandler<EventArgs> LoadStyle;
        public event EventHandler<EventArgs> LoadSeason;
        public event EventHandler<EventArgs> LoadColor;
        public int cId;
        System.Windows.Forms.ComboBox comboBoxStyle;
        System.Windows.Forms.ComboBox comboBoxSeason;
        System.Windows.Forms.ComboBox comboBoxColor;
        public Form3()
        {
            InitializeComponent();
        }

        public void SetSeason(string s)
        {
            textBoxSeason.Text = s;
        }
        public void SetSeasonToEdit(string s)
        {
            comboBoxSeason.Items.Add(s);
        }
        public void SetStyle(string s)
        {
            textBoxStyle.Text = s;
        }
        public void SetStyleToEdit(string s)
        {
            comboBoxStyle.Items.Add( s);
        }
        public void SetColor(string s)
        {
            textBoxColor.Text = s;
        }
        public void SetColorToEdit(string s)
        {
            comboBoxColor.Items.Add(s);
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
            textBoxName.Enabled = true;
            textBoxDate.Enabled = true;
            textBoxPlace.Enabled = true;
            textBoxSize.Enabled = true;
            LoadEditStyle();
            LoadEditSeason();
            LoadEditColor();
        }
        void LoadEditStyle()
        {
            try {
                comboBoxStyle = new System.Windows.Forms.ComboBox();
                comboBoxStyle.Location = textBoxStyle.Location;
                comboBoxStyle.Size = textBoxStyle.Size;
                LoadStyle?.Invoke(this, EventArgs.Empty);
                comboBoxStyle.SelectedText = textBoxStyle.Text;
                this.Controls.Remove(textBoxStyle);
                this.Controls.Add(comboBoxStyle);
            }
            catch { }
        }
        void LoadEditSeason()
        {
            try
            {
                comboBoxSeason = new System.Windows.Forms.ComboBox();
                comboBoxSeason.Location = textBoxSeason.Location;
                comboBoxSeason.Size = textBoxSeason.Size;
                LoadSeason?.Invoke(this, EventArgs.Empty);
                comboBoxSeason.SelectedText = textBoxSeason.Text;
                this.Controls.Remove(textBoxSeason);
                this.Controls.Add(comboBoxSeason);
            }
            catch { }
        }
        void LoadEditColor()
        {
            try
            {
                comboBoxColor = new System.Windows.Forms.ComboBox();
                comboBoxColor.Location = textBoxColor.Location;
                comboBoxColor.Size = textBoxColor.Size;
                LoadColor?.Invoke(this, EventArgs.Empty);
                comboBoxColor.SelectedText = textBoxColor.Text;
                this.Controls.Remove(textBoxColor);
                this.Controls.Add(comboBoxColor);
            }
            catch { }
        }
        private void delete(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("вы действительно хотите удалить\n " + textBoxName.Text + " из гардероба", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pictureBox1.Image.Dispose();            
                 DeleteItem?.Invoke(this, EventArgs.Empty);
                 this.Close();
                MessageBox.Show("одежда  удалена!");
            }
        }

        private void SaveIt(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("вы хотите сохранить изменения", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EditItem?.Invoke(this, EventArgs.Empty);
                this.Close();
                MessageBox.Show("измененения сохранены успешно");
            }
        }
    }
}
