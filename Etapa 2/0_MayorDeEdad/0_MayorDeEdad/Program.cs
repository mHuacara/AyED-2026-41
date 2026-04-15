using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Le preguntaremos su edad y le diremos si es mayor de edad o no");
            Console.Write("Ponga su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.Write("Usted es mayor de edad");
            }
            else
            {
                Console.Write("Usted no es mayor de edad");
            }
            Console.ReadKey();



        }
    }
}
