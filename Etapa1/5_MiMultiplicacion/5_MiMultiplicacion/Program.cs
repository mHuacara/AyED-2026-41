using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MiMultiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.WriteLine("Ponga dos numeros enteros para una multiplicacion");
            Console.Write("Ponga un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ponga otro numero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.Write("El resultado de su multiplicacion es de: ");
            Console.Write(resultado);
            Console.ReadKey();

        }
    }
}
