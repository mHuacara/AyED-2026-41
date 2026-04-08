using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            float numero3;
            double promedio;
            Console.WriteLine("Tendras que escribir 1 numero por cada peticion");
            Console.Write("Dime un numero: ");
            numero1 = float.Parse(Console.ReadLine());
            Console.Write("Dime otro numero: ");
            numero2 = float.Parse(Console.ReadLine());
            Console.Write("Dime un ultimo numero: ");
            numero3 = float.Parse(Console.ReadLine());
            promedio = (numero1 + numero2 + numero3) / 3;
            Console.Write("El promedio de la suma de tus numeros es de: ");
            Console.WriteLine(promedio);
            Console.ReadKey();


        }
    }
}
