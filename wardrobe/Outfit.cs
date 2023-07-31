using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal class Outfit
    {
        public string outfit_name;
        public ICollection <Clothes_Item> outfit;
        public string? photo;
    }
}
