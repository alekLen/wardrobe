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
        public Form6()
        {
            InitializeComponent();
        }

        private void LoadF6(object sender, EventArgs e)
        {
            try
            {
                int a = 6;
                int y = 50;
                for (int i = 0; i < a; i++)
                {
                    TextBox textbox = new TextBox();
                    textbox.Location = new System.Drawing.Point(20, y);
                    textbox.Width = 200;
                    this.Controls.Add(textbox);
                    for (int i1 = 0; i1 < 4; i1++)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        pictureBox.Location = new System.Drawing.Point(250 + i1 * 120, y);
                        pictureBox.BackColor = System.Drawing.Color.Gray;
                        //  Id_Item = MainForm.Ids[i];
                        // TakePhoto?.Invoke(this, new EventArgs());
                        pictureBox.Image = Image.FromFile("Photos/up.png");
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        this.Controls.Add(pictureBox);
                    }
                    y += 120;
                }
            }
            catch { }
        }
    }
}
