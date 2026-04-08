using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MiResta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.WriteLine("Tendra que poner dos numeros enteros para una resta");
            Console.Write("Ponga un numero: ");
            numero1 =int.Parse(Console.ReadLine());
            Console.Write("Pónga otro numero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.Write("El resultado de la resta de sus numeros enteros es: ");
            Console.Write(resultado);
            Console.ReadKey();

        }
    }
}
