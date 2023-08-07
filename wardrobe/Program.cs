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