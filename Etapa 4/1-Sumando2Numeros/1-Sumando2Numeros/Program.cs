using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dime un numero entero: ");
           int a = int.Parse(Console.ReadLine());
            Console.Write("Dime otro numero entero: ");
           int b = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("La suma de tus dos numeros: ");
            int resultado = suma(a, b);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
        static int suma(int a,int b)
        {
            return a + b;
        }
    }
}
