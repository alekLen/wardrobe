namespace wardrobe
{
    public partial class Form1 : Form,IForm1
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SetSeasonToWardrobe(string s)
        {
            listBox6.Items.Add(s);
        }
        public void SetStyleToWardrobe(string s)
        {
            listBox7.Items.Add(s);
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
            listBox5.Items.Add(s);
        }
    }
}