using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contador = 0;
            Console.WriteLine("Le pediremos que escriba cualquier palabra");
            Console.Write("Escriba una palabra: ");
            palabra = Console.ReadLine();
            Console.WriteLine("Su palabra repetida 10 veces: ");
            while(contador<10)
            {
                contador++;
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
        }
    }
}
