using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Le pediremos un numero entero positivo");
            Console.Write("Escriba un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Esta es una cuenta regresiva de su numero hasta 0");
            while (numero >=0)
            {
                Console.WriteLine(numero);
                numero--;
            }
            Console.ReadKey();

        }
    }
}
