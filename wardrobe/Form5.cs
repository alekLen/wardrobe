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
        public string Path { get; set; }
        public int Id_Item { get; set; }
        public event EventHandler<EventArgs> TakePhoto;
        public Form5()
        {
            InitializeComponent();
        }

        private void LoadF5(object sender, EventArgs e)
        {
            int a=MainForm.Ids.Count;
            for (int i = 0; i < a; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 200;
                pictureBox.Height = 200;
                pictureBox.Location = new System.Drawing.Point(20 + i * 220, 100);
                pictureBox.BackColor = System.Drawing.Color.Gray;
                // pictureBox.Image = Image.FromFile("Photos/up.png");
                Id_Item = MainForm.Ids[i];
                TakePhoto?.Invoke(this, new EventArgs());
                pictureBox.Image = Image.FromFile(Path);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pictureBox);

            }
            this.Width = a * 220 + 100;
        }       
       
    }
}
