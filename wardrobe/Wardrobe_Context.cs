using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal class Wardrobe_Context : DbContext
    {
       
        public Wardrobe_Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Clothes_Item> clothes_items { get; set; }
        public DbSet<Outfit> outfits { get; set; }
        public DbSet<Album> albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // метод UseLazyLoadingProxies() делает доступной ленивую загрузку.
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=DESKTOP-G30VB0K\MSSQLSERVER01;Database=Wardrobe;Integrated Security=SSPI;TrustServerCertificate=true;");
        }
    }
}
