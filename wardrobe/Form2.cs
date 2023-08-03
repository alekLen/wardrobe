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
    public partial class Form2 : Form
    {
        public event EventHandler<EventArgs> LoadF2;
        public Form1 MainForm { get; set; }
        public Form2()
        {
            InitializeComponent();

        }

        private void LoadForm2(object sender, EventArgs e)
        {
            try
            {
                LoadF2?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
