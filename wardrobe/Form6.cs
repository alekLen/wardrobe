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
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int c1 { get; set; }
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
                for (int i = 0; i < a; i++)
                {
                    TakeName?.Invoke(this, new EventArgs());
                    TextBox textbox = new TextBox();
                    textbox.Location = new System.Drawing.Point(20, y);
                    textbox.Width = 200;
                    textbox.Text = s;
                    this.Controls.Add(textbox);
                    CountItems?.Invoke(this, new EventArgs());
                    c1 = 0;
                    for (int i1 = 0; i1 < b; i1++)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        pictureBox.Location = new System.Drawing.Point(250 + i1 * 120, y);
                        pictureBox.BackColor = System.Drawing.Color.Gray;
                        //  Id_Item = MainForm.Ids[i];
                        TakePhoto?.Invoke(this, new EventArgs());
                        pictureBox.Image = Image.FromFile("Photos/up.png");
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        this.Controls.Add(pictureBox);
                        c1++;
                    }
                    y += 120;
                    c++;
                }
            }
            catch { }
        }
    }
}
