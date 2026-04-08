using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float celcius;
            double kelvin;
            double farenheit;
            Console.WriteLine("Tendra que ingresar un numero que sera considerado en celcius y lo pasaremos a farenheit y kelvin");
            Console.Write("Ingrese un numero: ");
            celcius = float.Parse(Console.ReadLine());
            farenheit = celcius * 1.8 + 32;
            kelvin = celcius + (-273.15);
            Console.Write("Su numero en celcius a farenheit es: ");
            Console.WriteLine(farenheit);
            Console.Write("Su numero en celcius a kelvin es: ");
            Console.Write(kelvin);
            Console.ReadKey();


        }
    }
}
