using Azure.Messaging;
using System.Windows.Forms;

namespace wardrobe
{
    public partial class Form1 : Form, IForm1
    {
        public Form2 add_clothe { get; set; } = new Form2();

        public event EventHandler<EventArgs> LoadF;
        public Form1()
        {
            InitializeComponent();

            try
            {

                pictureBox2.Image = Image.FromFile("Photos/up.png");
                pictureBox1.Image = Image.FromFile("Photos/bottom.png");
                pictureBox3.Image = Image.FromFile("Photos/dress.png");
                pictureBox4.Image = Image.FromFile("Photos/shoe.jpg");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void SetSeasonToWardrobe(string s)
        {
            comboBox2.Items.Add(s);
        }
        public void SetStyleToWardrobe(string s)
        {
            comboBox3.Items.Add(s);
        }
        public void SetTypeUpToWardrobe(string s)
        {
            listBox1.Items.Add(s);
        }
        public void SetTypeBottomToWardrobe(string s)
        {
            listBox2.Items.Add(s);
        }
        public void SetTypeSuitToWardrobe(string s)
        {
            listBox3.Items.Add(s);
        }
        public void SetTypeShoeToWardrobe(string s)
        {
            listBox4.Items.Add(s);
        }
        public void SetColorToWardrobe(string s)
        {
            comboBox1.Items.Add(s);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            try
            {
                LoadF?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Form(object sender, EventArgs e)
        {
            add_clothe.MainForm = this;
            add_clothe.Show();
        }
    }
}