using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compara
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan los datos en tipo string y se convierten a tipo entero
             * para despues almacenarse en variables*/
            string _numero1, _numero2;
            int numero1, numero2;
            Console.Write("Numero 1: ");
            _numero1 = Console.ReadLine();
            Console.Write("Numero 2: ");
            _numero2 = Console.ReadLine();
            numero1 = Convert.ToInt32(_numero1);
            numero2 = Convert.ToInt32(_numero2);
            //Un if dentro de otro, ambos con salida de falso
            if (numero1 == numero2)
            {
                Console.WriteLine(string.Format("Numeros proporcionados {0} y {1}. {2}", numero1, numero2, "Los numeros son iguales."));
            }
            else
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine(string.Format("Numeros proporcionados {0} y {1}. {2}", numero1, numero2, "El mayor es el primero"));
                }
                else
                {
                    Console.WriteLine(string.Format("Numeros proporcionados {0} y {1}. {2}", numero1, numero2, "El mayor es el segundo."));
                }
            }
            //Pausa
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();
        }
    }
}
