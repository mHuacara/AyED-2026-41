using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AnioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("Le pediremos que ingrese un año y le diremos si es bisiesto o no");
            Console.Write("Ingrese un año: ");
            año = int.Parse(Console.ReadLine());
            if (año%4==0 && año%100!=0 || año%400==0)
            {
                Console.Write("El año si es bisiesto");
            }
            else
            {
                Console.Write("Su año no es bisisesto");
            }
            Console.ReadKey();

        }
    }
}
