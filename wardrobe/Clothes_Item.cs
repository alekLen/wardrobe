using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal class Clothes_Item
    {
        public int Id { get; set; }
        public string Clothes_Item_name { get; set; }
        public Colors color { get; set; }
        public Clothes_type type { get; set; }
        public Season season { get; set; }
        public Clothes_style style { get; set; }
        // public DateTime? date { get; set; }
        public string? date { get; set; }
        public string? place { get; set; }
        public string? size { get; set; }
        public string photo { get; set; }
        public virtual ICollection<Outfit> outfits { get; set; }
    }
}
