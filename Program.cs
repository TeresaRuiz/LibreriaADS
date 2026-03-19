using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaADS
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Usuario usuarioDAO = new Usuario();

            if (usuarioDAO.ExisteAdministrador())
            {
                Application.Run(new FormLogin());
            }
            else
            {
                Application.Run(new Carga());
            }
        }
    }
}
