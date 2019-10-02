using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Si valores que se necesita que sean numericos se capturan en string
             * se define una variable para el valor capturado y otra para el valor
             * en el tipo que se ocupa*/
            string _numero;
            int numero;
            /*Se ingresa el dato en tipo string y se convierte a numero*/
            Console.Write("Dame un numero del 1 al 9: ");
            _numero = Console.ReadLine();
            numero = Convert.ToInt32(_numero);

            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(string.Format("{0} x {1} = {2}", numero, i, numero * i));
            }
            //Pausa
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();
        }
    }
}
