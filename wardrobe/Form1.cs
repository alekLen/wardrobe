using Azure.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wardrobe
{
    public partial class Form1 : Form, IForm1
    {
        public Form2 add_clothe { get; set; } = new Form2();
        public Form3 see_clothe { get; set; } = new Form3();
        public int setId { get; set; }
       
        public event EventHandler<EventArgs> LoadF;
        public event EventHandler<EventArgs> LoadUp;
        public event EventHandler<EventArgs> LoadBottom;
        public event EventHandler<EventArgs> LoadSuit;
        public event EventHandler<EventArgs> LoadShoe;
        public event EventHandler<EventArgs> NewF3;
        public Form1()
        {
            InitializeComponent();

            try
            {

                pictureBox1.Image = Image.FromFile("Photos/up.png");
                pictureBox2.Image = Image.FromFile("Photos/bottom.png");
                pictureBox3.Image = Image.FromFile("Photos/dress.png");
                pictureBox4.Image = Image.FromFile("Photos/shoe.jpg");
                listView1.Columns.Add(null, 300);
                listView2.Columns.Add(null, 300);
                listView3.Columns.Add(null, 300);
                listView4.Columns.Add(null, 300);
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
            listView1.Items.Add(s);
        }
        public void SetTypeBottomToWardrobe(string s)
        {
            ListViewItem item1 = new ListViewItem(s);
            listView2.Items.Add(item1);
        }
        public void SetTypeSuitToWardrobe(string s)
        {
            ListViewItem item1 = new ListViewItem(s);
            listView3.Items.Add(item1);
        }
        public void SetTypeShoeToWardrobe(string s)
        {
            ListViewItem item1 = new ListViewItem(s);
            listView4.Items.Add(item1);
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
                LoadUp?.Invoke(this, EventArgs.Empty);
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

        private void Load_see_form(object sender, EventArgs e)
        {
            try
            {
                if(see_clothe.IsDisposed || see_clothe.Visible)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    see_clothe.Show();
                }
            }
            catch { MessageBox.Show("ops"); }
        }
    }
}