using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado;
            float perimetro;
            float superficie;
            Console.WriteLine("Le solicitaremos el lado de un cuadrado");
            Console.Write("Ponga una medida de un lado de un cuadrado: ");
            lado = float.Parse(Console.ReadLine());
            perimetro =  lado* 4;
            superficie = lado * lado;
            Console.Write("El perimetro de su cuadrado es de: ");
            Console.WriteLine(perimetro);
            Console.Write("La superficie de su cuadrado es de: ");
            Console.WriteLine(superficie);
            Console.ReadKey();

        }
    }
}
