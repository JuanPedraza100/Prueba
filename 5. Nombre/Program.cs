using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellidos;
            Console.Write("Captura un nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Captura los apellidos: ");
            apellidos = Console.ReadLine();
            //Se asigna a la variable su version en mayusculas
            nombre = nombre.ToUpper();
            apellidos = apellidos.ToUpper();
            /*StringBuilder se le asigna una instancia de clase new, el constructor
             * le aporta la primera parte y posteriormente se añaden las demas*/
            StringBuilder nombreCompleto = new StringBuilder(nombre);
            nombreCompleto.Append(" ");
            nombreCompleto.Append(apellidos);

            Console.WriteLine(nombreCompleto);
            //Pausa
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();

        }
    }
}
