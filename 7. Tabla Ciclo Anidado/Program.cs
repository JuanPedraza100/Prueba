using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablasCicloAnidado
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(string.Format("Tabla del {0}: ", i));
                Console.WriteLine("");
                //Un for anidado con otro, permite combinar sus variables de secuencia//
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(string.Format("{0} x {1} = {2}", i, j, i * j));
                }
            }
            //Pausa
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();
        }
    }
}
