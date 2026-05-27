using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Configuracion regional para toda la app, con esto manejo formatos fechas y separador de miles y decimales
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-CO");
            CultureInfo cultura = new CultureInfo("es-CO");

            cultura.NumberFormat.NumberDecimalSeparator = ",";
            cultura.NumberFormat.NumberGroupSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = cultura;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultura;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Aca se indica que formulario se iniciara al ejecutar la aplicacion, en este caso se inicia con el formulario de Login, pero se podria iniciar directamente con el formulario de Inicio si se desea omitir el proceso de autenticacion (esto es solo para pruebas, en un entorno real no deberia existir esta opcion)
            Application.Run(new Inicio());
            //Application.Run(new Login());
        }
    }
}
