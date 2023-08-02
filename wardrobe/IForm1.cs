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
        public event EventHandler<EventArgs> Load;

    }
}
