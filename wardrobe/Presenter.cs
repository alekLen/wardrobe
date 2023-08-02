﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace wardrobe
{
    internal class Presenter
    {
        private readonly IForm1 form;
        public Presenter(IForm1 f)
        {
            form = f;
            form.Load += new EventHandler<EventArgs>(Load);
          
        }
        public void Load(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
           
             ToSeasonBox(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ToSeasonBox(Wardrobe_Context db)
        {
            try
            {

                using (db)
                {
                    var query = from b in db.seasons
                                select b;

                    foreach (var p in query)
                    {
                        string s = p.Season_name;
                        form.SetSeasonToWardrobe(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Wardrobe_Context Get_db()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<Wardrobe_Context>();
            var options = optionsBuilder.UseSqlServer(connectionString).Options;
            var db = new Wardrobe_Context(options);
            return db;
        }
    }
}
