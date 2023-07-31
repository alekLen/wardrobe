using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal class Clothes_Item
    {
        public string Clothes_Item_name { get; set; }
        public Colors color;
        public Clothes_type type;
        public Season season;
        public Clothes_style style;
        public DateTime? date;
        public string? place;
        public string? size;
        public string photo;
    }
}
