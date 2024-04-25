using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyento
{
    /*programa de herencia
     * heramienta es la caracteristicas
     * de pasar atributos y metodos 
     * a otros objetops o clase*/
    //clase mamá
    class Operacion
    {
        /*guarda los espacios
         * de memoria 3 valopres */
        //multiblicador tipo de datos nombre
        protected int valor1;
        protected int valor2;
        protected int resultado;



    }



    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
