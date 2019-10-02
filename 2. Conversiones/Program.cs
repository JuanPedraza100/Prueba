using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables declaradas escribiendo el tipo de dato,
             * despues el nombre de la variable y un valor de inicio
             */
            string numero = "1234";
            //Se convierte a tipo entero y se muestra el tipo de dato
            Console.WriteLine(numero.GetType().ToString());
            int intNumero = Convert.ToInt32(numero);
            Console.WriteLine(intNumero.GetType().ToString());
            //String.Format realiza macro substituciones
            Console.WriteLine(String.Format("El numero es {0}", intNumero));
            //Pausa
            Console.ReadLine();
        }
    }
}
