using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            float metros;
            float centimetros;
            double milimetros;
            Console.WriteLine("Tendra que poner una medida en metros");
            Console.Write("Ponga una medida: ");
            metros = float.Parse(Console.ReadLine());
            centimetros = metros * 100;
            milimetros = metros * 1000;
            Console.Write("Su medida en metros a centimetros es de: ");
            Console.WriteLine(centimetros);
            Console.Write("Su medida en metros a milimetros es de: ");
            Console.WriteLine(milimetros);
            Console.ReadKey();

           
        }
    }
}
