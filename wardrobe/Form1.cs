using Azure.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wardrobe
{
    public partial class Form1 : Form, IForm1
    {
        public Form2 add_clothe { get; set; } = new Form2();
        public Form3 see_clothe { get; set; } = new Form3();
        public Form4 edit_form { get; set; } = new Form4();
        public int setId { get; set; }
        public List<int> Ids { get; set; }

        public event EventHandler<EventArgs> LoadF;
        public event EventHandler<EventArgs> LoadUp;
        public event EventHandler<EventArgs> LoadBottom;
        public event EventHandler<EventArgs> LoadSuit;
        public event EventHandler<EventArgs> LoadShoe;
        public event EventHandler<EventArgs> NewF2;
        public event EventHandler<EventArgs> NewF3;
        public Form1()
        {
            InitializeComponent();

            try
            {
                Ids = new();
                pictureBox1.Image = Image.FromFile("Photos/up.png");
                pictureBox2.Image = Image.FromFile("Photos/bottom.png");
                pictureBox3.Image = Image.FromFile("Photos/dress.png");
                pictureBox4.Image = Image.FromFile("Photos/shoe.jpg");
                listView1.Columns.Add("верх", 300);
                listView2.Columns.Add("низ", 300);
                listView3.Columns.Add("платье/костюм", 300);
                listView4.Columns.Add("обувь", 300);
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
        public void ClearUp()
        {
            listView1.Items.Clear();
        }
        public void SetTypeBottomToWardrobe(string s)
        {
            ListViewItem item1 = new ListViewItem(s);
            listView2.Items.Add(item1);
        }
        public void ClearBottom()
        {
            listView2.Items.Clear();
        }
        public void SetTypeSuitToWardrobe(string s)
        {
            ListViewItem item1 = new ListViewItem(s);
            listView3.Items.Add(item1);
        }
        public void ClearSuit()
        {
            listView3.Items.Clear();
        }
        public void SetTypeShoeToWardrobe(string s)
        {
            ListViewItem item1 = new ListViewItem(s);
            listView4.Items.Add(item1);
        }
        public void ClearShoe()
        {
            listView4.Items.Clear();
        }
        public void SetColorToWardrobe(string s)
        {
            comboBox1.Items.Add(s);
        }
        public void SetChoseItemUp(string s)
        {
            listBox1.Items.Add(s);
            label9.Text = listBox1.Items.Count.ToString();
        }
        public void SetPhotoItemUp(string s)
        {
            pictureBox1.Image = Image.FromFile(s);
        }
        public void SetChoseItemBottom(string s)
        {
            listBox2.Items.Add(s);
            label10.Text = listBox2.Items.Count.ToString();
        }
        public void SetPhotoItemBottom(string s)
        {
            pictureBox2.Image = Image.FromFile(s);
        }
        public void SetChoseItemSuit(string s)
        {
            listBox3.Items.Add(s);
            label11.Text = listBox3.Items.Count.ToString();
        }
        public void SetPhotoItemSuit(string s)
        {
            pictureBox3.Image = Image.FromFile(s);
        }
        public void SetChoseItemShoe(string s)
        {
            listBox4.Items.Add(s);
            label12.Text = listBox4.Items.Count.ToString();
        }
        public void SetPhotoItemShoe(string s)
        {
            pictureBox4.Image = Image.FromFile(s);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            try
            {
                LoadF?.Invoke(this, EventArgs.Empty);
                LoadUp?.Invoke(this, EventArgs.Empty);
                LoadBottom?.Invoke(this, EventArgs.Empty);
                LoadSuit?.Invoke(this, EventArgs.Empty);
                LoadShoe?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Form(object sender, EventArgs e)
        {
            if (add_clothe.IsDisposed || add_clothe.Visible)
            {
                add_clothe = new Form2();
                NewF2?.Invoke(this, EventArgs.Empty);
            }
            add_clothe.MainForm = this;
            add_clothe.Show();
        }

        private void Load_see_formUp(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed || see_clothe.Visible)
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
            catch { MessageBox.Show("opsup"); }
        }

        private void Load_see_formBottom(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed || see_clothe.Visible)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView2.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView2.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    see_clothe.Show();
                }
            }
            catch { MessageBox.Show("opsbottom"); }
        }

        private void Load_see_formSuit(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed || see_clothe.Visible)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView3.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView3.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    see_clothe.Show();
                }
            }
            catch { MessageBox.Show("opssuit"); }
        }

        private void Load_see_formShoe(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed || see_clothe.Visible)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView4.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView4.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    see_clothe.Show();
                }
            }
            catch { MessageBox.Show("opsshoe"); }
        }

        private void editStyle(object sender, EventArgs e)
        {

        }

        private void delStyle(object sender, EventArgs e)
        {

        }

        private void addStyle(object sender, EventArgs e)
        {

        }
    }
}