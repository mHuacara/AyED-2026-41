using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double pi;
            double superficie;
            double volumen;
            pi = 3.14159265;
            Console.WriteLine("Ingrese el radio de una esfera");
            Console.Write("Ingrese un radio: ");
            radio = double.Parse(Console.ReadLine());
            superficie = 4 * pi * Math.Pow(radio, 2);
            volumen=4/3*pi*Math.Pow(radio,3);
            Console.Write("La superficie de su esfera es: ");
            Console.WriteLine(superficie);
            Console.Write("El volumen de su esfera es: ");
            Console.Write(volumen);
            Console.ReadKey();




        }
    }
}
