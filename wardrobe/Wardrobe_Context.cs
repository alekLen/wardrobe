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
        // Для работы с БД MS SQL Server необходимо добавить пакет:
        // Microsoft.EntityFrameworkCore.SqlServer(представляет функциональность Entity Framework для работы с MS SQL Server)

        // Microsoft.Extensions.Configuration.Json. Этот пакет специально предназначен для работы с конфигурацией в формате json.

        public Wardrobe_Context(DbContextOptions<Wardrobe_Context> options)
           : base(options)
        {
            if (Database.EnsureCreated())
            {
                Clothes_style style1 = new Clothes_style {Style_name = "Повседневный" };
                Clothes_style style2 = new Clothes_style { Style_name = "Спортивный" };
                Clothes_style style3 = new Clothes_style { Style_name = "Вечерний" };
                Clothes_style style4 = new Clothes_style { Style_name = "Рабочий" };

                clothes_styles.Add(style1);
                clothes_styles.Add(style2);
                clothes_styles.Add(style3);
                clothes_styles.Add(style4);

                Clothes_type type1 = new Clothes_type { Type_name = "верх" };
                Clothes_type type2 = new Clothes_type { Type_name = "низ" };
                Clothes_type type3 = new Clothes_type { Type_name = "платье/костюм" };
                Clothes_type type4 = new Clothes_type { Type_name = "обувь" };

                clothes_types.Add(type1);
                clothes_types.Add(type2);
                clothes_types.Add(type3);
                clothes_types.Add(type4);

                SaveChanges();
            }
        }
        public DbSet<Clothes_style> clothes_styles { get; set; }
        public DbSet<Clothes_type> clothes_types { get; set; }
        public DbSet<Season> seasons { get; set; }
        public DbSet<Colors> colors { get; set; }
        public DbSet<Clothes_Item> clothes_items { get; set; }
        public DbSet<Outfit> outfits { get; set; }
        public DbSet<Album> albums { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {         
        }
    }
}
