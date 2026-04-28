using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            string afirmacion = "SI";
            string palabra;
            Console.Write("Quiere terminar el programa?: ");
            palabra = Console.ReadLine();
            while (afirmacion != palabra)
            {
                Console.Write("Quiere terminar el programa?: ");
                palabra = Console.ReadLine();
            }
            Console.Write("Programa terminado");
            Console.ReadKey();
        }
    }
}
