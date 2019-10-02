using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    class Program
    {
        //F= Valor Float
        static public float numero1 = 24.5F;
        static void Main(string[] args)
        {
            //Declaracion de variables
            float numero2 = 0.0F;
            //Definicion de valor aleatorio
            Random numAleatorio = new Random();
            numero2 = (float)numAleatorio.Next(1, 11);
            Console.WriteLine(string.Format("La suma de {0} y {1} es {2}", numero1, numero2, numero1 + numero2));
            //Pausa
            Console.ReadLine();
        }
    }
}
