using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero;
            int numero;
            bool esMultiplo3, esMultiplo5, esMultiplo7;

            try
            {
                Console.WriteLine("Dame un numero entero: ");
                _numero = Console.ReadLine();
                numero = Convert.ToInt32(_numero);
                /*Si el numero tiene un residual de cero con respecto
                 * a un numero, es que es su multiplo*/
                esMultiplo3 = ((numero % 3) == 0);
                esMultiplo5 = ((numero % 5) == 0);
                esMultiplo7 = ((numero % 7) == 0);
                /*Si es multiplo de 3 y de 5 al mismo tiempo, o si es
                 * multiplo de 7 es correcto*/
                if ((esMultiplo3 & esMultiplo5) | esMultiplo7)
                {
                    Console.WriteLine("Correcto");
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El dato proporcionado causa errores");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Pausa
                Console.WriteLine("");
                Console.WriteLine("Presiona INTRO para continuar");
                Console.ReadKey();
            }
        }
    }
}
