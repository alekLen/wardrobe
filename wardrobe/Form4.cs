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
    public partial class Form4 : Form
    {
        public string category { get; set; }
        public string action { get; set; }
        public event EventHandler<EventArgs> LoadEditStyle;
        public event EventHandler<EventArgs> LoadEditColor;
        public event EventHandler<EventArgs> LoadEditType;
        public Form1 MainForm { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void Load_Form4(object sender, EventArgs e)
        {
             if (action == "edit")
             {
                 this.Text = "редактирование";
                 textBox1.Enabled = true;
                 button1.Text = "изменить";
             }
             if (action == "delete")
             {
                 this.Text = "удаление";
                 textBox1.Enabled = false;
                 button1.Text = "удалить";
             }
             if (action == "add")
             {
                 this.Text = "добавление";
                 textBox1.Enabled = true;
                 button1.Text = "добавить";
             }
            if (category == "style")
            {
                LoadEditStyle?.Invoke(this, EventArgs.Empty);
            }
            if (category == "season")
            {
                LoadEditStyle?.Invoke(this, EventArgs.Empty);
            }
            if (category == "color")
            {
                LoadEditStyle?.Invoke(this, EventArgs.Empty);
            }

        }
    }
}
