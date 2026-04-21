using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado1;
            float lado2;
            float lado3;
            Console.WriteLine("Le pediremos tres lados para un triangulo");
            Console.Write("Escriba una medida para un lado: ");
            lado1 = float.Parse(Console.ReadLine());
            Console.Write("Escriba una medida para otro lado: ");
            lado2 = float.Parse(Console.ReadLine());
            Console.Write("Escriba una medida para un ultimo lado: ");
            lado3 = float.Parse(Console.ReadLine());
            if (lado1 + lado2 <= lado3 || lado3 + lado1 <= lado2 || lado2 + lado3 <= lado1)
            {
                Console.WriteLine("No se puede formar un triangulo");
            }
            else if (lado1 + lado2 > lado3 || lado3 + lado1 > lado2 || lado2 + lado3 > lado1)
            {
                Console.Write("Si se puede formar un triangulo"+",");

                if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                {
                    Console.Write("puede formar un triangulo equilatero");
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    Console.Write("puede formar un triangulo isosceles");
                }
                else
                {
                    Console.Write("puede formar un triangulo escaleno");
                }
            }
            Console.ReadKey();



        }
    }
}
