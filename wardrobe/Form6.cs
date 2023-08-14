using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wardrobe
{
    public partial class Form6 : Form
    {
        public event EventHandler<EventArgs> CountComplects;
        public event EventHandler<EventArgs> CountItems;
        public event EventHandler<EventArgs> TakeName;
        public event EventHandler<EventArgs> TakePhoto;
        public event EventHandler<EventArgs> DeleteComplect;
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int c1 { get; set; }
        public int n { get; set; }
        public string s { get; set; }
        public List<int> Complects { get; set; } = new();
        public List<int> Items { get; set; } = new();
        public Form6()
        {
            InitializeComponent();
        }

        private void LoadF6(object sender, EventArgs e)
        {
            try
            {
                CountComplects?.Invoke(this, new EventArgs());
                int y = 50;
                c = 0;
                n = 0;
                for (int i = 0; i < a; i++)
                {
                    TakeName?.Invoke(this, new EventArgs());
                    TextBox textbox = new TextBox();
                    textbox.Location = new System.Drawing.Point(20, y);
                    textbox.Width = 200;
                    textbox.Text = s;
                    textbox.Enabled = false;
                    this.Controls.Add(textbox);
                    CountItems?.Invoke(this, new EventArgs());
                    c1 = 0;
                    int x = 0;
                    for (int i1 = 0; i1 < b; i1++)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        pictureBox.Location = new System.Drawing.Point(250 + i1 * 120, y);
                        pictureBox.BackColor = System.Drawing.Color.Gray;
                        TakePhoto?.Invoke(this, new EventArgs());
                        pictureBox.Image = Image.FromFile(s);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        this.Controls.Add(pictureBox);
                        c1++; n++;
                        x = i1;
                    }
                    Button button = new Button();
                    button.Text = "удалить комплект";
                    button.Name = "button." + i;
                    button.Width = 150;
                    button.Height = 50;
                    button.Click += Button_Click;
                    button.Location = new System.Drawing.Point(250 + x * 120 + 150, y);
                    this.Controls.Add(button);
                    y += 120;
                    c++;
                }
            }
            catch { }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string s= clickedButton.Name;
            string[] s1 = s.Split('.');
            n = int.Parse(s1[1]);
            DialogResult result = MessageBox.Show("уверены , что хотите удалить комплект ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteComplect?.Invoke(this, new EventArgs());
                this.Close();
            }
        }
    }
}
