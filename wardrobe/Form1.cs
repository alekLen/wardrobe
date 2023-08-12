using Azure.Messaging;
using System.Drawing;
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
        public List<int> Ids { get; set; } = new();
        public List<string> f_color { get; set; } = new();
        public List<string> f_style { get; set; } = new();
        public List<string> f_season { get; set; } = new();

        public event EventHandler<EventArgs> LoadF;
        public event EventHandler<EventArgs> LoadUp;
        public event EventHandler<EventArgs> LoadBottom;
        public event EventHandler<EventArgs> LoadSuit;
        public event EventHandler<EventArgs> LoadShoe;
        public event EventHandler<EventArgs> NewF2;
        public event EventHandler<EventArgs> NewF3;
        public event EventHandler<EventArgs> NewF4;
        public event EventHandler<EventArgs> Filtr;
        public event EventHandler<EventArgs> Clear_Filtr;
        public event EventHandler<EventArgs> Change_Photo_Up;
        public event EventHandler<EventArgs> Change_Photo_Bottom;
        public event EventHandler<EventArgs> Change_Photo_Suit;
        public event EventHandler<EventArgs> Change_Photo_Shoe;
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
                listView5.Columns.Add("параметры:", 140);
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
            bool q = true;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == s) q = false;
            }
            if (q)
            {
                listView1.Items.Add(s);
            }
        }
        public void ClearUp()
        {
            listView1.Items.Clear();
        }
        public void SetTypeBottomToWardrobe(string s)
        {
            bool q = true;
            foreach (ListViewItem item in listView2.Items)
            {
                if (item.Text == s) q = false;
            }
            if (q)
            {
                ListViewItem item1 = new ListViewItem(s);
                listView2.Items.Add(item1);
            }
        }
        public void ClearBottom()
        {
            listView2.Items.Clear();
        }
        public void SetTypeSuitToWardrobe(string s)
        {
            bool q = true;
            foreach (ListViewItem item in listView3.Items)
            {
                if (item.Text == s) q = false;
            }
            if (q)
            {
                ListViewItem item1 = new ListViewItem(s);
                listView3.Items.Add(item1);
            }
        }
        public void ClearSuit()
        {
            listView3.Items.Clear();
        }
        public void SetTypeShoeToWardrobe(string s)
        {
            bool q = true;
            foreach (ListViewItem item in listView4.Items)
            {
                if (item.Text == s) q = false;
            }
            if (q)
            {
                ListViewItem item1 = new ListViewItem(s);
                listView4.Items.Add(item1);
            }
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
            label13.Text = listBox1.Items.Count.ToString();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        public void SetPhotoItemUp(string s)
        {
            pictureBox1.Image = Image.FromFile(s);
        }
        public void SetChoseItemBottom(string s)
        {
            listBox2.Items.Add(s);
            label14.Text = listBox2.Items.Count.ToString();
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }
        public void SetPhotoItemBottom(string s)
        {
            pictureBox2.Image = Image.FromFile(s);
        }
        public void SetChoseItemSuit(string s)
        {
            listBox3.Items.Add(s);
            label15.Text = listBox3.Items.Count.ToString();
            listBox3.SelectedIndex = listBox3.Items.Count - 1;
        }
        public void SetPhotoItemSuit(string s)
        {
            pictureBox3.Image = Image.FromFile(s);
        }
        public void SetChoseItemShoe(string s)
        {
            listBox4.Items.Add(s);
            label16.Text = listBox4.Items.Count.ToString();
            listBox4.SelectedIndex = listBox4.Items.Count - 1;
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
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "style";
                edit_form.action = "edit";
                edit_form.Show();
            }
            catch { }
        }

        private void delStyle(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "style";
                edit_form.action = "delete";
                edit_form.Show();
            }
            catch { }
        }

        private void addStyle(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "style";
                edit_form.action = "add";
                edit_form.Show();
            }
            catch { }
        }

        private void delSeason(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "season";
                edit_form.action = "delete";
                edit_form.Show();
            }
            catch { }
        }

        private void editSeason(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "season";
                edit_form.action = "edit";
                edit_form.Show();
            }
            catch { }
        }

        private void addSeason(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "season";
                edit_form.action = "add";
                edit_form.Show();
            }
            catch { }
        }

        private void delColor(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "color";
                edit_form.action = "delete";
                edit_form.Show();
            }
            catch { }
        }

        private void editColor(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "color";
                edit_form.action = "edit";
                edit_form.Show();
            }
            catch { }
        }

        private void addColor(object sender, EventArgs e)
        {
            try
            {
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "color";
                edit_form.action = "add";
                edit_form.Show();
            }
            catch { }
        }
        public void ClearStyleBox()
        {
            comboBox3.Items.Clear();
        }
        public void ClearSeasonBox()
        {
            comboBox2.Items.Clear();
        }
        public void ClearColorBox()
        {
            comboBox1.Items.Clear();
        }

        private void filter_color(object sender, EventArgs e)
        {
            f_color.Add(comboBox1.SelectedItem.ToString());
            ListViewItem item1 = new ListViewItem(comboBox1.SelectedItem.ToString());
            listView5.Items.Add(item1);
        }

        private void filter_season(object sender, EventArgs e)
        {
            f_season.Add(comboBox2.SelectedItem.ToString());
            ListViewItem item1 = new ListViewItem(comboBox2.SelectedItem.ToString());
            listView5.Items.Add(item1);
        }

        private void filter_style(object sender, EventArgs e)
        {
            f_style.Add(comboBox3.SelectedItem.ToString());
            ListViewItem item1 = new ListViewItem(comboBox3.SelectedItem.ToString());
            listView5.Items.Add(item1);
        }

        private void filter_Start(object sender, EventArgs e)
        {
            if (f_color.Count > 0 || f_season.Count > 0 || f_style.Count > 0)
            {
                Filtr?.Invoke(this, EventArgs.Empty);
            }

        }

        private void clear_filter(object sender, EventArgs e)
        {
            f_color.Clear();
            f_season.Clear();
            f_style.Clear();
            listView5.Items.Clear();
            Clear_Filtr?.Invoke(this, EventArgs.Empty);
        }

        private void Add_Complect(object sender, EventArgs e)
        {

        }

        private void del_Choosen_Up(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    string s = listBox1.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox1.Image = Image.FromFile("Photos/up.png");
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        label13.Text = listBox1.Items.Count.ToString();
                        if (listBox1.Items.Count > 0)
                        {
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            string s2 = listBox1.Items[listBox1.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Up?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void del_chosen_bottom(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedIndex != -1)
                {
                    string s = listBox2.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox2.Image = Image.FromFile("Photos/bottom.png");
                        listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                        label14.Text = listBox2.Items.Count.ToString();
                        if (listBox2.Items.Count > 0)
                        {
                            listBox2.SelectedIndex = listBox2.Items.Count - 1;
                            string s2 = listBox2.Items[listBox2.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Bottom?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void del_chosen_suit(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.SelectedIndex != -1)
                {
                    string s = listBox3.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox3.Image = Image.FromFile("Photos/dress.png");
                        listBox3.Items.RemoveAt(listBox3.SelectedIndex);
                        label15.Text = listBox3.Items.Count.ToString();
                        if (listBox3.Items.Count > 0)
                        {
                            listBox3.SelectedIndex = listBox3.Items.Count - 1;
                            string s2 = listBox3.Items[listBox3.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Suit?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void del_chosen_shoe(object sender, EventArgs e)
        {
            try
            {
                if (listBox4.SelectedIndex != -1)
                {
                    string s = listBox4.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox4.Image = Image.FromFile("Photos/shoe.jpg");
                        listBox4.Items.RemoveAt(listBox4.SelectedIndex);
                        label16.Text = listBox4.Items.Count.ToString();
                        if (listBox4.Items.Count > 0)
                        {
                            listBox4.SelectedIndex = listBox4.Items.Count - 1;
                            string s2 = listBox4.Items[listBox4.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Shoe?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void selectUp(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string s = listBox1.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Up?.Invoke(this, new EventArgs());
            }
        }

        private void selectBottom(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string s = listBox2.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Bottom?.Invoke(this, new EventArgs());
            }
        }

        private void selectSuit(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                string s = listBox3.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Suit?.Invoke(this, new EventArgs());
            }
        }

        private void selectShoe(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex != -1)
            {
                string s = listBox4.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Shoe?.Invoke(this, new EventArgs());
            }
        }
    }
}