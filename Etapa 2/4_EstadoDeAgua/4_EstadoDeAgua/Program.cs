using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperatura;
            Console.WriteLine("Tendra que ingresar una temperatura en Celcius");
            Console.Write("Ingrese una temperatura en grados celcius: ");
            temperatura = float.Parse(Console.ReadLine());
            if (temperatura <= 0)
            {
                Console.Write("Se congela");
            }
            else if(temperatura>=100)
            {
                Console.Write("Hierve");
            }
            else
            {
                Console.Write("Esta en estado liquido");
            }
            Console.ReadKey();
    

        }
    }
}
