using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MiSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.WriteLine("Tendra que poner dos numero enteros para una suma");
            Console.Write("Ponga un numero entero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ponga otro numero entero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.Write("El resultado de su suma de enteros es: ");
            Console.Write(resultado);
            Console.ReadKey();
        }
    }
}
