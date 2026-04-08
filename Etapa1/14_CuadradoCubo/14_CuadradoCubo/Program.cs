using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubico;
            Console.WriteLine("Le pediremos que coloque un numero");
            Console.Write("Coloque un numero: ");
            numero = double.Parse(Console.ReadLine());
            cuadrado = Math.Pow(numero, 2);
            cubico = Math.Pow(numero, 3);
            Console.Write("El cuadrado de su numero es de: ");
            Console.WriteLine(cuadrado);
            Console.Write("EL cubo de su numero es de: ");
            Console.WriteLine(cubico);
            Console.ReadKey();

        }
    }
}
