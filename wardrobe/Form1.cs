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
        public void SetTypeToWardrobe(string s)
        {

        }
        public void SetColorToWardrobe(string s)
        {
            listBox5.Items.Add(s);
        }
    }
}