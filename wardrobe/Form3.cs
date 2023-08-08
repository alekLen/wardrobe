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
        public event EventHandler<EventArgs> DeletePhoto;
        public int cId { get; set; }
        public string newphoto { get; set; } 
        public string oldphoto { get; set; }
        public string newName { get; set; }
        public string oldName { get; set; }
        public string newStyle { get; set; }
        public string oldStyle { get; set; }
        public string newSeason { get; set; }
        public string oldSeason { get; set; }
        public string newColor { get; set; }
        public string oldColor { get; set; }
        public string newDate { get; set; }
        public string oldDate { get; set; }
        public string newPlace { get; set; }
        public string oldPlace { get; set; }
        public string newSize { get; set; }
        public string oldSize { get; set; }

        System.Windows.Forms.ComboBox comboBoxStyle;
        System.Windows.Forms.ComboBox comboBoxSeason;
        System.Windows.Forms.ComboBox comboBoxColor;
        System.Windows.Forms.Button buttonPhoto;
        public Form3()
        {
            InitializeComponent();
        }

        public void SetSeason(string s)
        {
            textBoxSeason.Text = s;
            oldSeason = s;
        }
        public void SetSeasonToEdit(string s)
        {
            comboBoxSeason.Items.Add(s);
        }
        public void SetStyle(string s)
        {
            textBoxStyle.Text = s;
            oldStyle = s;
        }
        public void SetStyleToEdit(string s)
        {
            comboBoxStyle.Items.Add( s);
        }
        public void SetColor(string s)
        {
            textBoxColor.Text = s;
            oldColor = s;
        }
        public void SetColorToEdit(string s)
        {
            comboBoxColor.Items.Add(s);
        }
        public void SetName(string s)
        {
            textBoxName.Text = s;
            oldName = s;
        }
        public void SetPlace(string s)
        {
            textBoxPlace.Text = s;
            oldPlace = s;
        }
        public void SetDate(string s)
        {
            textBoxDate.Text = s;
            oldDate = s;
        }
        public void SetSize(string s)
        {
            textBoxSize.Text = s;
            oldSize = s;
        }
        public void SetPhoto(string s)
        {
            pictureBox1.Image = Image.FromFile(s);
            oldphoto = s;
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
            LoadPhotoButton();
        }
        void LoadPhotoButton()
        {
            buttonPhoto =new System.Windows.Forms.Button();
            buttonPhoto.Location = button1.Location;
            buttonPhoto.Size = button1.Size;
            buttonPhoto.Text = "изменить фото";
            this.Controls.Remove(button1);
            this.Controls.Add(buttonPhoto);
            buttonPhoto.Click += buttonPhoto_Click;

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
            DialogResult result = MessageBox.Show("вы хотите сохранить изменения\n если изменили фото, то старое будет удалено", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SetNewData();
                if (newphoto != null)
                {
                    pictureBox1.Image.Dispose();
                    DeletePhoto?.Invoke(this, EventArgs.Empty);
                }
                EditItem?.Invoke(this, EventArgs.Empty);               
                MessageBox.Show("измененения сохранены успешно");
            }
            if (result == DialogResult.No)
            {
                if (newphoto != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(oldphoto);
                }
            }
        }
        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newphoto = openFileDialog.FileName;
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(newphoto);
                }
            }
        }
        void SetNewData()
        {
            newName = textBoxName.Text;
            newSeason=comboBoxSeason.Text;
            newStyle=comboBoxStyle.Text;
            newColor=comboBoxColor.Text;
            newDate=textBoxDate.Text;
            newPlace=textBoxPlace.Text;
            newSize=textBoxSize.Text;
        }
    }
}
