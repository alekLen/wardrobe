using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal class Outfit
    {
        public int Id { get; set; }
        public string outfit_name { get; set; }
        public virtual ICollection<Clothes_Item> clothes_items { get; set; } =new List<Clothes_Item>();
        public string? photo { get; set; }
        public virtual Album? album { get; set; }
      
    }
}
