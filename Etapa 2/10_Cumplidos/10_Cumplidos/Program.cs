using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int contador = 0;
            Console.WriteLine("Le pediremos su edad");
            Console.Write("Cuantos años tiene?: ");
            edad = int.Parse(Console.ReadLine());
            while (contador < edad)
            {
                contador++;
                Console.WriteLine("Una vez tuvo " + contador + " de edad");
            }
            Console.ReadKey();

        }
    }
}
