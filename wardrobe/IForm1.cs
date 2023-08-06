using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wardrobe
{
    public interface IForm1
    {
        public void SetSeasonToWardrobe(string s);
        public void SetStyleToWardrobe(string s);
        public void SetTypeUpToWardrobe(string s);
        public void SetTypeBottomToWardrobe(string s);
        public void SetTypeSuitToWardrobe(string s);
        public void SetTypeShoeToWardrobe(string s);
        public void SetColorToWardrobe(string s);
        public int setId { get; set; }

        public event EventHandler<EventArgs> LoadF;
        public event EventHandler<EventArgs> LoadUp;
        public event EventHandler<EventArgs> LoadBottom;
        public event EventHandler<EventArgs> LoadSuit;
        public event EventHandler<EventArgs> LoadShoe;
        public Form2 add_clothe { get; set; }
        public Form3 see_clothe { get; set; } 

    }
}
