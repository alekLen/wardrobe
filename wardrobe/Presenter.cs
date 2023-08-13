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
using System.Windows.Forms.VisualStyles;
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
            form.NewF4 += new EventHandler<EventArgs>(NewEForm);
            form.NewF5 += new EventHandler<EventArgs>(NewСForm);
            form.NewF6 += new EventHandler<EventArgs>(NewСcForm);
            form.LoadUp += new EventHandler<EventArgs>(Load_Up);
            form.LoadBottom += new EventHandler<EventArgs>(Load_Bottom);
            form.LoadSuit += new EventHandler<EventArgs>(Load_Suit);
            form.LoadShoe += new EventHandler<EventArgs>(Load_Shoe);
            form.Filtr += new EventHandler<EventArgs>(Filter);
            form.Clear_Filtr += new EventHandler<EventArgs>(UpdateFm1);
            form.Change_Photo_Up += new EventHandler<EventArgs>(SetPhotoUp);
            form.Change_Photo_Bottom += new EventHandler<EventArgs>(SetPhotoBottom);
            form.Change_Photo_Suit += new EventHandler<EventArgs>(SetPhotoSuit);
            form.Change_Photo_Shoe += new EventHandler<EventArgs>(SetPhotoShoe);
            form.add_clothe.LoadF2 += new EventHandler<EventArgs>(LoadAdd);
            form.add_clothe.Save_clothes += new EventHandler<EventArgs>(SaveAdd);        
            form.see_clothe.LoadF3 += new EventHandler<EventArgs>(LoadSeeForm);
            form.see_clothe.AddToCom += new EventHandler<EventArgs>(AddToChose);
            form.see_clothe.DeleteItem += new EventHandler<EventArgs>(DeleteItemFromWardrobe);
            form.see_clothe.LoadStyle += new EventHandler<EventArgs>(LoadStyleToEdit);
            form.see_clothe.LoadSeason += new EventHandler<EventArgs>(LoadSeasonToEdit);
            form.see_clothe.LoadColor += new EventHandler<EventArgs>(LoadColorToEdit);
            form.see_clothe.DeletePhoto += new EventHandler<EventArgs>(DelPhoto);
            form.see_clothe.EditItem += new EventHandler<EventArgs>(EditItem);
            form.edit_form.LoadEditStyle += new EventHandler<EventArgs>(LoadStyleToEdit);
            form.edit_form.LoadEditSeason += new EventHandler<EventArgs>(LoadSeasonToEdit);
            form.edit_form.LoadEditColor += new EventHandler<EventArgs>(LoadColorToEdit);
            form.edit_form.LoadShowStyle += new EventHandler<EventArgs>(LoadStyleToE);
            form.edit_form.LoadShowSeason += new EventHandler<EventArgs>(LoadSeasonToE);
            form.edit_form.LoadShowColor += new EventHandler<EventArgs>(LoadColorToE);
           form.edit_form.AddStyle += new EventHandler<EventArgs>(AddStyle);
           form.edit_form.AddSeason += new EventHandler<EventArgs>(AddSeason);
            form.edit_form.AddColor += new EventHandler<EventArgs>(AddColor);
            form.edit_form.EditStyle += new EventHandler<EventArgs>(EditStyle);
            form.edit_form.EditSeason += new EventHandler<EventArgs>(EditSeason);
            form.edit_form.EditColor += new EventHandler<EventArgs>(EditColor);
            form.edit_form.DeleteStyle += new EventHandler<EventArgs>(DeleteStyle);
            form.edit_form.DeleteSeason += new EventHandler<EventArgs>(DeleteSeason);
            form.edit_form.DeleteColor += new EventHandler<EventArgs>(DeleteColor);
            form.complect_form.TakePhoto+=new EventHandler<EventArgs>(PhotoToComplect);
            form.complect_form.SaveComplect += new EventHandler<EventArgs>(SaveComplect);
            form.complects_show_form.CountComplects += new EventHandler<EventArgs>(CountComplects);
            form.complects_show_form.CountItems += new EventHandler<EventArgs>(CountItems);
            form.complects_show_form.TakeName += new EventHandler<EventArgs>(TakeName);
            form.complects_show_form.TakePhoto += new EventHandler<EventArgs>(TakePhoto);
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
                    savePhoto(form.add_clothe.FilePath);
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
       void savePhoto(string s)
        {
            try
            {
                string targetFolderPath = Path.Combine(Application.StartupPath, "Photos");
            if (!Directory.Exists(targetFolderPath))
            {
                Directory.CreateDirectory(targetFolderPath);
            }
            targetFilePath = Path.Combine(targetFolderPath, Path.GetFileName(s));
            File.Copy(s, targetFilePath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                targetFilePath = null;
            }
        }
        public void deletePhoto(string s)
        {
            try
            {
                if (File.Exists(s))
                {
                    File.Delete(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        public void UpdateFm1(object sender, EventArgs e)
        {
            try
            {
                    form.ClearUp();
                    Load_Up(sender, e);
                    form.ClearBottom();
                    Load_Bottom(sender, e);
                    form.ClearSuit();
                    Load_Suit(sender, e);
                    form.ClearShoe();
                    Load_Shoe(sender, e);
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
        public void LoadSeasonToEdit(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query1 = from b in db.seasons
                             select b;

                foreach (var p in query1)
                {
                    string s = p.Season_name;
                    if (sender is Form3)
                        form.see_clothe.SetSeasonToEdit(s);
                    if (sender is Form4)
                        form.edit_form.SetCategory(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSeasonToE(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query1 = from b in db.seasons
                             select b;

                foreach (var p in query1)
                {
                    string s = p.Season_name;
                        form.edit_form.ShowCategory(s);
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
        public void LoadStyleToEdit(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = from b in db.clothes_styles
                            select b;

                foreach (var p in query)
                {
                    string s = p.Style_name;
                    if (sender is Form3)
                        form.see_clothe.SetStyleToEdit(s);
                    if (sender is Form4)
                        form.edit_form.SetCategory(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadStyleToE(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = from b in db.clothes_styles
                            select b;

                foreach (var p in query)
                {
                    string s = p.Style_name;                 
                        form.edit_form.ShowCategory(s);
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
        public void LoadColorToEdit(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = from b in db.colors
                            select b;

                foreach (var p in query)
                {
                    string s = p.Color_name;
                    if (sender is Form3)
                        form.see_clothe.SetColorToEdit(s);
                    if (sender is Form4)
                        form.edit_form.SetCategory(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadColorToE(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = from b in db.colors
                            select b;

                foreach (var p in query)
                {
                    string s = p.Color_name;                  
                        form.edit_form.ShowCategory(s);
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
            form.see_clothe.DeleteItem += new EventHandler<EventArgs>(DeleteItemFromWardrobe);
            form.see_clothe.LoadStyle += new EventHandler<EventArgs>(LoadStyleToEdit);
            form.see_clothe.LoadSeason += new EventHandler<EventArgs>(LoadSeasonToEdit);
            form.see_clothe.LoadColor += new EventHandler<EventArgs>(LoadColorToEdit);
            form.see_clothe.DeletePhoto += new EventHandler<EventArgs>(DelPhoto);
            form.see_clothe.EditItem += new EventHandler<EventArgs>(EditItem);
        }
        public void NewAForm(object sender, EventArgs e)
        {
            form.add_clothe.LoadF2 += new EventHandler<EventArgs>(LoadAdd);
            form.add_clothe.Save_clothes += new EventHandler<EventArgs>(SaveAdd);
        }
        public void NewEForm(object sender, EventArgs e)
        {
            form.edit_form.LoadEditStyle += new EventHandler<EventArgs>(LoadStyleToEdit);
            form.edit_form.LoadEditSeason += new EventHandler<EventArgs>(LoadSeasonToEdit);
            form.edit_form.LoadEditColor += new EventHandler<EventArgs>(LoadColorToEdit);
            form.edit_form.LoadShowStyle += new EventHandler<EventArgs>(LoadStyleToE);
            form.edit_form.LoadShowSeason += new EventHandler<EventArgs>(LoadSeasonToE);
            form.edit_form.LoadShowColor += new EventHandler<EventArgs>(LoadColorToE);
            form.edit_form.AddStyle += new EventHandler<EventArgs>(AddStyle);
            form.edit_form.AddSeason += new EventHandler<EventArgs>(AddSeason);
            form.edit_form.AddColor += new EventHandler<EventArgs>(AddColor);
            form.edit_form.EditStyle += new EventHandler<EventArgs>(EditStyle);
            form.edit_form.EditSeason += new EventHandler<EventArgs>(EditSeason);
            form.edit_form.EditColor += new EventHandler<EventArgs>(EditColor);
            form.edit_form.DeleteStyle += new EventHandler<EventArgs>(DeleteStyle);
            form.edit_form.DeleteSeason += new EventHandler<EventArgs>(DeleteSeason);
            form.edit_form.DeleteColor += new EventHandler<EventArgs>(DeleteColor);
        }
        public void NewСForm(object sender, EventArgs e)
        {
            form.complect_form.TakePhoto += new EventHandler<EventArgs>(PhotoToComplect);
            form.complect_form.SaveComplect += new EventHandler<EventArgs>(SaveComplect);
        }
        public void NewСcForm(object sender, EventArgs e)
        {
            form.complects_show_form.CountComplects += new EventHandler<EventArgs>(CountComplects);
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
                                select b.type.Type_name+"|"+ b.photo + "|" + b.Id + "." + b.Clothes_Item_name).Single();
                  form.Ids.Add(form.see_clothe.cId);
                    string[] s = query.Split('|');
                    if (s[0] == "верх")
                    {
                        form.SetChoseItemUp(s[2]);
                        form.SetPhotoItemUp(s[1]);
                    }
                    if (s[0] == "низ")
                    {
                        form.SetChoseItemBottom(s[2]);
                        form.SetPhotoItemBottom(s[1]);
                    }
                    if (s[0] == "платье/костюм")
                    {
                        form.SetChoseItemSuit(s[2]);
                        form.SetPhotoItemSuit(s[1]);
                    }
                    if (s[0] == "обувь")
                    {
                        form.SetChoseItemShoe(s[2]);
                        form.SetPhotoItemShoe(s[1]);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteItemFromWardrobe(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = (from b in db.clothes_items
                                 where b.Id == form.see_clothe.cId
                                 select b.photo).Single();
                    deletePhoto(q);
                    var query = (from b in db.clothes_items
                                 where b.Id == form.see_clothe.cId
                                select b).Single();
                    db.Remove(query);
                    db.SaveChanges();
                    UpdateFm1(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DelPhoto(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = (from b in db.clothes_items
                             where b.Id == form.see_clothe.cId
                             select b.photo).Single();
                    deletePhoto(q);                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditItem(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = (from b in db.clothes_items
                             where b.Id == form.see_clothe.cId
                             select b).Single();
                    if (form.see_clothe.newSeason != form.see_clothe.oldSeason)
                    {
                        var query1 = (from b in db.seasons
                                     where b.Season_name == form.see_clothe.newSeason
                                     select b).Single();
                        q.season = query1;
                    }
                    if (form.see_clothe.newStyle != form.see_clothe.oldStyle)
                    {
                        var query1 = (from b in db.clothes_styles
                                      where b.Style_name == form.see_clothe.newStyle
                                      select b).Single();
                        q.style = query1;
                    }
                    if (form.see_clothe.newColor != form.see_clothe.oldColor)
                    {
                        var query1 = (from b in db.colors
                                      where b.Color_name == form.see_clothe.newColor
                                      select b).Single();
                        q.color = query1;
                    }
                    if (form.see_clothe.newName != form.see_clothe.oldName)
                    {
                        q.Clothes_Item_name = form.see_clothe.newName; 
                    }
                    if (form.see_clothe.newDate != form.see_clothe.oldDate)
                    {
                        q.date=form.see_clothe.newDate;
                    }
                    if (form.see_clothe.newPlace != form.see_clothe.oldPlace)
                    {
                        q.place = form.see_clothe.newPlace;
                    }
                    if (form.see_clothe.newSize != form.see_clothe.oldSize)
                    {
                        q.size=form.see_clothe.newSize;
                    }
                    if (form.see_clothe.newphoto != form.see_clothe.oldphoto && form.see_clothe.newphoto !=null )
                    {
                        savePhoto(form.see_clothe.newphoto);
                        q.photo = form.see_clothe.newphoto;
                    }
                        db.SaveChanges();
                    UpdateFm1(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddStyle(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                Clothes_style style = new ();
                style.Style_name = form.edit_form.name;
                db.Add(style);
                db.SaveChanges();
                form.ClearStyleBox();
                ToStyleBox(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddSeason(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                Season season = new ();
                season.Season_name = form.edit_form.name;
                db.Add(season);
                db.SaveChanges();
                form.ClearSeasonBox();
                ToSeasonBox(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddColor(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                Colors color = new Colors();
                color.Color_name = form.edit_form.name;
                db.Add(color);
                db.SaveChanges();
                form.ClearColorBox();
                ToColorBox(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditStyle(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = (from b in db.clothes_styles
                            where b.Style_name == form.edit_form.oldname
                            select b).Single();
               query.Style_name = form.edit_form.name;              
                db.SaveChanges();
                form.ClearStyleBox();
                ToStyleBox(db);
                UpdateFm1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditSeason(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = (from b in db.seasons
                             where b.Season_name == form.edit_form.oldname
                             select b).Single();
                query.Season_name = form.edit_form.name;
                db.SaveChanges();
                form.ClearSeasonBox();
                ToSeasonBox(db);
                UpdateFm1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditColor(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = (from b in db.colors
                             where b.Color_name == form.edit_form.oldname
                             select b).Single();
                query.Color_name = form.edit_form.name;
                db.SaveChanges();
                form.ClearColorBox();
                ToColorBox(db);
                UpdateFm1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteStyle(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = (from b in db.clothes_styles
                             where b.Style_name == form.edit_form.oldname
                             select b).Single();
                db.Remove(query);
                db.SaveChanges();
                form.ClearStyleBox();
                ToStyleBox(db);
                UpdateFm1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteSeason(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = (from b in db.seasons
                             where b.Season_name == form.edit_form.oldname
                             select b).Single();
                db.Remove(query);
                db.SaveChanges();
                form.ClearSeasonBox();
                ToSeasonBox(db);
                UpdateFm1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteColor(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                var query = (from b in db.colors
                             where b.Color_name == form.edit_form.oldname
                             select b).Single();
                db.Remove(query);
                db.SaveChanges();
                form.ClearColorBox();
                ToColorBox(db);
                UpdateFm1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Filter(object sender, EventArgs e)
        {
            try
            { 
                form.ClearUp();
                form.ClearBottom();
                form.ClearSuit();
                form.ClearShoe();
                Wardrobe_Context db = Get_db();
                foreach(string a in form.f_color)
                {
                    filter_Color(db, a);
                }
                foreach (string a in form.f_style)
                {
                    filter_Style(db, a);
                }
                foreach (string a in form.f_season)
                {
                    filter_Season(db, a);
                }

                ToColorBox(db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void filter_Color(Wardrobe_Context db, string a)
        {
            var query1 = from b in db.clothes_items
                         where b.color.Color_name == a && b.type.Type_name == "обувь"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query1)
                form.SetTypeShoeToWardrobe(i);
            var query2 = from b in db.clothes_items
                         where b.color.Color_name == a && b.type.Type_name == "верх"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query2)
                form.SetTypeUpToWardrobe(i);
            var query3 = from b in db.clothes_items
                         where b.color.Color_name == a && b.type.Type_name == "низ"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query3)
                form.SetTypeBottomToWardrobe(i);
            var query4 = from b in db.clothes_items
                         where b.color.Color_name == a && b.type.Type_name == "платье/костюм"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query4)
                form.SetTypeSuitToWardrobe(i);
        }
        void filter_Style(Wardrobe_Context db, string a)
        {
            var query1 = from b in db.clothes_items
                         where b.style.Style_name == a && b.type.Type_name == "обувь"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query1)
                form.SetTypeShoeToWardrobe(i);
            var query2 = from b in db.clothes_items
                         where b.style.Style_name == a && b.type.Type_name == "верх"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query2)
                form.SetTypeUpToWardrobe(i);
            var query3 = from b in db.clothes_items
                         where b.style.Style_name == a && b.type.Type_name == "низ"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query3)
                form.SetTypeBottomToWardrobe(i);
            var query4 = from b in db.clothes_items
                         where b.style.Style_name == a && b.type.Type_name == "платье/костюм"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query4)
                form.SetTypeSuitToWardrobe(i);
        }
        void filter_Season(Wardrobe_Context db, string a)
        {
            var query1 = from b in db.clothes_items
                         where b.season.Season_name == a && b.type.Type_name == "обувь"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query1)
                form.SetTypeShoeToWardrobe(i);
            var query2 = from b in db.clothes_items
                         where b.season.Season_name == a && b.type.Type_name == "верх"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query2)
                form.SetTypeUpToWardrobe(i);
            var query3 = from b in db.clothes_items
                         where b.season.Season_name == a && b.type.Type_name == "низ"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query3)
                form.SetTypeBottomToWardrobe(i);
            var query4 = from b in db.clothes_items
                         where b.season.Season_name == a && b.type.Type_name == "платье/костюм"
                         select b.Id + "." + b.Clothes_Item_name + "___" + b.color.Color_name + "___" + b.style.Style_name + "___" + b.season.Season_name;
            foreach (var i in query4)
                form.SetTypeSuitToWardrobe(i);
        }
        public void SetPhotoUp(object sender, EventArgs e)
        {
           string s= GetPhoto();
            form.SetPhotoItemUp(s);
        }
        public void SetPhotoBottom(object sender, EventArgs e)
        {
            string s = GetPhoto();
            form.SetPhotoItemBottom(s);
        }
        public void SetPhotoSuit(object sender, EventArgs e)
        {
            string s = GetPhoto();
            form.SetPhotoItemSuit(s);
        }
        public void SetPhotoShoe(object sender, EventArgs e)
        {
            string s = GetPhoto();
            form.SetPhotoItemShoe(s);
        }
        string GetPhoto()
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = (from b in db.clothes_items
                             where b.Id == form.setId
                             select b.photo).Single();
                    return q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return null;
            }
        }
        public void PhotoToComplect(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = (from b in db.clothes_items
                             where b.Id == form.complect_form.Id_Item
                             select b.photo).Single();
                    form.complect_form.Path = q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SaveComplect(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    Outfit complect = new();
                    complect.outfit_name = form.complect_form.Path;
                    db.outfits.Add(complect);
                    foreach (int i in form.Ids)
                    {
                        var q = (from b in db.clothes_items
                                 where b.Id == i
                                 select b).Single();
                        complect.clothes_items.Add(q);
                    }                  
                    db.SaveChanges();
                    form.complect_form.sucses = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                form.complect_form.sucses = false;
            }
        }
        public void CountComplects(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    form.complects_show_form.a = db.outfits.Count();
                    var q = from b in db.outfits
                            select b.Id;
                    foreach (int i in q)
                        form.complects_show_form.Complects.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }
        public void CountItems(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = db.outfits
                            .Where(c => c.Id == form.complects_show_form.Complects[form.complects_show_form.c])
                            .SelectMany(c => c.clothes_items)
                            .ToList();
                    form.complects_show_form.b = q.Count();
                    foreach (var i in q)
                    {
                        var q1 = (from b in db.clothes_items
                                where b == i
                                select b.Id).Single();
                        form.complects_show_form.Items.Add(q1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TakeName(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = (from b in db.outfits
                             where b.Id == form.complects_show_form.Complects[form.complects_show_form.c]
                             select b.outfit_name).Single();
                    form.complects_show_form.s = q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TakePhoto(object sender, EventArgs e)
        {
            try
            {
                Wardrobe_Context db = Get_db();
                using (db)
                {
                    var q = (from b in db.clothes_items
                             where b.Id == form.complects_show_form.Items[form.complects_show_form.n]
                             select b.photo).Single();
                    form.complects_show_form.s = q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

