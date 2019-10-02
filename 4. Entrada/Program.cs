using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una variable es para la entrada de informacion y la otra
             * para recibir el valor equivalente*/
            string valor;
            int receptora = 0;
            Console.Write("Escribe algo; ");
            valor = Console.ReadLine();

            //Pregunta si el valor ingresado se puede convertir a entero
            if (int.TryParse(valor, out receptora))
            {
                //De ser posible la conversion, el valor se almacena en la variable y se muestra
                Console.WriteLine(string.Format("Dato entero {0}. Muy bien!", receptora));
            }
            else
            {
                //En caso de no ser convertido, se envia un mensaje de error
                Console.WriteLine("Dato no es entero. Intentar de nuevo.");
            }
            //Pausa
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();
        }
    }
}
