using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace wardrobe
{
    internal class Presenter
    {
        private readonly IForm1 form;
        string targetFilePath;
        public Presenter(IForm1 f)
        {
            form = f;
            form.LoadF += new EventHandler<EventArgs>(LoadAll);
            form.NewF2 += new EventHandler<EventArgs>(NewAForm);
            form.NewF3 += new EventHandler<EventArgs>(NewSForm);
            form.LoadUp += new EventHandler<EventArgs>(Load_Up);
            form.LoadBottom += new EventHandler<EventArgs>(Load_Bottom);
            form.LoadSuit += new EventHandler<EventArgs>(Load_Suit);
            form.LoadShoe += new EventHandler<EventArgs>(Load_Shoe);
            form.add_clothe.LoadF2 += new EventHandler<EventArgs>(LoadAdd);
            form.add_clothe.Save_clothes += new EventHandler<EventArgs>(SaveAdd);        
            form.see_clothe.LoadF3 += new EventHandler<EventArgs>(LoadSeeForm);
            form.see_clothe.AddToCom += new EventHandler<EventArgs>(AddToChose);
        }
        public void LoadAll(object sender, EventArgs e)
        {
            try
            {
               Wardrobe_Context db = Get_db();
                using (db)
                {
                    ToSeasonBox(db);
                    ToStyleBox(db);
                    ToColorBox(db);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadAdd(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    SeasonToForm2(db);
                    StyleToForm2(db);
                    ColorToForm2(db);
                    TypeToForm2(db);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSeeForm(object sender, EventArgs e)
        {
            try
            {

                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var query = (from b in db.clothes_items
                                where b.Id == form.setId
                                 select b.Id + "~" + b.Clothes_Item_name + "~" + b.type.Type_name + "~" + b.color.Color_name + "~" + b.style.Style_name + "~" + b.season.Season_name + "~" + b.date + "~" + b.place + "~" + b.size + "~" + b.photo).Single();
                    string s = query.ToString();
                    string[]s1=s.Split('~');
                    form.see_clothe.SetName(s1[1]);
                    form.see_clothe.SetSeason(s1[5]);
                    form.see_clothe.SetStyle(s1[4]);
                    form.see_clothe.SetColor(s1[3]);
                    form.see_clothe.SetPhoto(s1[9]);
                    form.see_clothe.SetDate(s1[6]);
                    form.see_clothe.SetPlace(s1[7]);
                    form.see_clothe.SetSize(s1[8]);
                    form.see_clothe.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Load_Up(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {                  
                    var query = from b in db.clothes_items
                                     where b.type.Type_name == "верх"
                                     select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" +b.season.Season_name;
                    foreach (var i in query)
                    { 
                        form.SetTypeUpToWardrobe(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Load_Bottom(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var query = from b in db.clothes_items
                                where b.type.Type_name == "низ"
                                select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
                    foreach (var i in query)
                    {
                        form.SetTypeBottomToWardrobe(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Load_Suit(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var query = from b in db.clothes_items
                                where b.type.Type_name == "платье/костюм"
                                select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
                    foreach (var i in query)
                    {
                        form.SetTypeSuitToWardrobe(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Load_Shoe(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var query = from b in db.clothes_items
                                where b.type.Type_name == "обувь"
                                select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
                    foreach (var i in query)
                    {
                        form.SetTypeShoeToWardrobe(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SaveAdd(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {                  
                    savePhoto();
                   if(targetFilePath != null)
                   {
                        Clothes_Item item = new Clothes_Item();
                        item.Clothes_Item_name = form.add_clothe.name;
                        item.photo = targetFilePath;
                        var type_query = (from b in db.clothes_types
                                     where b.Type_name == form.add_clothe.type
                                     select b).Single();
                        item.type=type_query;
                        var style_query = (from b in db.clothes_styles
                                          where b.Style_name == form.add_clothe.style
                                           select b).Single();
                        item.style=style_query;
                        var season_query = (from b in db.seasons
                                           where b.Season_name == form.add_clothe.season
                                            select b).Single();
                        item.season=season_query;
                        var color_query = (from b in db.colors
                                            where b.Color_name == form.add_clothe.color
                                            select b).Single();
                        item.color=color_query;
                        item.place = form.add_clothe.place;
                        item.size = form.add_clothe.size;
                        item.date= form.add_clothe.date;
                        db.clothes_items.Add(item);
                        db.SaveChanges();
                        UpdateForm1(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       void savePhoto()
        {
            try
            {
                string targetFolderPath = Path.Combine(Application.StartupPath, "Photos");
            if (!Directory.Exists(targetFolderPath))
            {
                Directory.CreateDirectory(targetFolderPath);
            }
            targetFilePath = Path.Combine(targetFolderPath, Path.GetFileName(form.add_clothe.FilePath));
            File.Copy(form.add_clothe.FilePath, targetFilePath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                targetFilePath = null;
            }
        }

        public void UpdateForm1(object sender, EventArgs e)
        {
            try
            {
                if(form.add_clothe.type=="верх")
                {
                    form.ClearUp();
                    Load_Up(sender, e);
                }
                if (form.add_clothe.type == "низ")
                {
                    form.ClearBottom();
                    Load_Bottom(sender, e);
                }
                if (form.add_clothe.type == "платье/костюм")
                {
                    form.ClearSuit();
                    Load_Suit(sender, e);
                }
                if (form.add_clothe.type == "обувь")
                {
                    form.ClearShoe();
                    Load_Shoe(sender, e);
                }
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
                    var query1 = from b in db.seasons
                                select b;

                    foreach (var p in query1)
                    {
                        string s = p.Season_name;
                        form.SetSeasonToWardrobe(s);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ToStyleBox(Wardrobe_Context db)
        {
            try
            {
                    var query = from b in db.clothes_styles
                                 select b;

                    foreach (var p in query)
                    {
                        string s = p.Style_name;
                        form.SetStyleToWardrobe(s);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ToColorBox(Wardrobe_Context db)
        {
            try
            {
                var query = from b in db.colors
                            select b;

                foreach (var p in query)
                {
                    string s = p.Color_name;
                    form.SetColorToWardrobe(s);
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
        public void SeasonToForm2(Wardrobe_Context db)
        {
            try
            {
                var query1 = from b in db.seasons
                             select b;

                foreach (var p in query1)
                {
                    string s = p.Season_name;
                    form.add_clothe.SetSeason(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void StyleToForm2(Wardrobe_Context db)
        {
            try
            {
                var query = from b in db.clothes_styles
                            select b;

                foreach (var p in query)
                {
                    string s = p.Style_name;
                    form.add_clothe.SetStyle(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ColorToForm2(Wardrobe_Context db)
        {
            try
            {
                var query = from b in db.colors
                            select b;

                foreach (var p in query)
                {
                    string s = p.Color_name;
                    form.add_clothe.SetColor(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TypeToForm2(Wardrobe_Context db)
        {
            try
            {
                var query = from b in db.clothes_types
                            select b;

                foreach (var p in query)
                {
                    string s = p.Type_name;
                    form.add_clothe.SetType(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        public void NewSForm(object sender, EventArgs e)
        {
            form.see_clothe.LoadF3 += new EventHandler<EventArgs>(LoadSeeForm);
            form.see_clothe.AddToCom += new EventHandler<EventArgs>(AddToChose);
        }
        public void NewAForm(object sender, EventArgs e)
        {
            form.add_clothe.LoadF2 += new EventHandler<EventArgs>(LoadAdd);
            form.add_clothe.Save_clothes += new EventHandler<EventArgs>(SaveAdd);
        }
        public void AddToChose(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var query = (from b in db.clothes_items
                                where b.Id == form.see_clothe.cId
                                select b.type.Type_name+"|"+b.Id + "." + b.Clothes_Item_name).Single();
                  form.Ids.Add(form.see_clothe.cId);
                    string[] s = query.Split('|');
                    if (s[0] == "верх")
                    {
                        form.SetChoseItemUp(s[1]);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
