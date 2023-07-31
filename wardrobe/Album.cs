using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal class Album
    {
        public int Id { get; set; }
        public string album_name { get; set; }
        public virtual ICollection<Outfit> outfits { get; set; }
    }
}
