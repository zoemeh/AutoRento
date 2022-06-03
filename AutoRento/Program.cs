using AutoRento.Data;
using AutoRento.UI;

namespace AutoRento
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            using AutoRentoContext db = new AutoRentoContext();
            var u = db.Usuarios.Where(x => x.nombre == "admin").FirstOrDefault();
            if (u == null)
            {
                u = new Models.Usuario();
                u.nombre = "admin";
                u.password = "admin";
                var repo = new UsuarioRepo();
                repo.Create(u);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}