using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dime un nombre: ");
            string resultado = nombre(Console.ReadLine());
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
        static string nombre(string nombre)
        {
            return " Hola " + nombre;
        }
    }
}
