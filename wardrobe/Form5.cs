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
    public partial class Form5 : Form
    {
        public Form1 MainForm { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void LoadF5(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 200;
                pictureBox.Height = 200;
                pictureBox.Location = new System.Drawing.Point(20 + i * 220, 100);
                pictureBox.BackColor = System.Drawing.Color.Gray;
                pictureBox.Image = Image.FromFile("Photos/up.png");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pictureBox);

            }
            this.Width = 5 * 220 + 100;
        }
    }
}
