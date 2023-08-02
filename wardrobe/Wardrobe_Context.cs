﻿using Microsoft.EntityFrameworkCore;
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

                clothes_styles.Add(style1);
              
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
