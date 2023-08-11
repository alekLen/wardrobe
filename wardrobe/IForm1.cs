﻿using System;
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
        public void ClearUp();
        public void ClearBottom();
        public void ClearSuit();
        public void ClearShoe();
        public int setId { get; set; }
        public List<int> Ids { get; set; }
        public void SetChoseItemUp(string s);
        public void SetPhotoItemUp(string s);
        public void SetChoseItemBottom(string s);
        public void SetPhotoItemBottom(string s);
        public void SetChoseItemSuit(string s);
        public void SetPhotoItemSuit(string s);
        public void SetChoseItemShoe(string s);
        public void SetPhotoItemShoe(string s);

        public event EventHandler<EventArgs> LoadF;
        public event EventHandler<EventArgs> LoadUp;
        public event EventHandler<EventArgs> LoadBottom;
        public event EventHandler<EventArgs> LoadSuit;
        public event EventHandler<EventArgs> LoadShoe;
        public event EventHandler<EventArgs> NewF2;
        public event EventHandler<EventArgs> NewF3;
        public event EventHandler<EventArgs> NewF4;
        public Form2 add_clothe { get; set; }
        public Form3 see_clothe { get; set; }
        public Form4 edit_form { get; set; } 

    }
}
