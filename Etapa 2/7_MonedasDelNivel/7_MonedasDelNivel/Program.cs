using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int monedadorada = 10;
            int monedaplateada = 2;
            int cantidaddorada;
            int cantidadplateada;
            int puntaje;
            Console.WriteLine("Le pediremos cuantras monedas consiguio de cada uno");
            Console.Write("Cuantas monedas de oro consiguio?: ");
            cantidaddorada = int.Parse(Console.ReadLine());
            Console.Write("Cuantas monedas de plata consiguio?: ");
            cantidadplateada = int.Parse(Console.ReadLine());
            puntaje = (monedadorada * cantidaddorada) + (monedaplateada * cantidadplateada);
            if (puntaje>=100)
            {
                Console.WriteLine("Nivel completado con bonus");
                Console.Write("Su puntaje fue de: " + puntaje);
            }
            else if (puntaje<=99 && puntaje>=50)
            {
                Console.WriteLine("Nivel superado");
                Console.Write("Su puntaje fue de: " + puntaje);
            }
            else
            {
                Console.WriteLine("Nivel insuficiente");
                Console.Write("Su puntaje fue de: " + puntaje);
            }
            Console.ReadKey();
            




        }
    }
}
