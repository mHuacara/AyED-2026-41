using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            float ingresos_mensuales;
            Console.WriteLine("Le preguntaremos su edad y sus ingresos mensuales");
            Console.Write("Ponga su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ponga sus ingresos mensuales: ");
            ingresos_mensuales = float.Parse(Console.ReadLine());
            if (edad > 19 && ingresos_mensuales <= 100000 || edad < 19 && ingresos_mensuales == 0 || edad == 19 && ingresos_mensuales <= 50000)
            {
                Console.Write("Si pueded cobrar la beca");
            }
            else
            {
                Console.Write("No puede cobrar la beca");
            }
            Console.ReadKey();


        }
    }
}
