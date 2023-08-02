using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace wardrobe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
            try
            {
               
              /*  var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");

                var optionsBuilder = new DbContextOptionsBuilder<Wardrobe_Context>();
                var options = optionsBuilder.UseSqlServer(connectionString).Options;

                Wardrobe_Context db = new Wardrobe_Context(options);*/
               
                /* using (LanguageContext db = new LanguageContext(options))
                 {
                     List<Language> list = db.Languages.Include(l => l.Continents).ToList();
                     foreach (var l in list)
                     {
                         Console.WriteLine(l.Name);
                         foreach (var cont in l.Continents)
                         {
                             Console.WriteLine("\t" + cont.Name);
                         }
                     }
                 }*/
                ApplicationConfiguration.Initialize();
               Form1 form = new Form1();
               Presenter presenter = new Presenter(form);
                Application.Run(form);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}