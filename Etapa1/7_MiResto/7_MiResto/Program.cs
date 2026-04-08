using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiResto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            float resultado;
            Console.WriteLine("Tendra que poner dos numeros enteros");
            Console.Write("Ponga un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ponga otro numero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 % numero2;
            Console.Write("El resto de su division de sus numeros es: ");
            Console.Write(resultado);
            Console.ReadKey();


        }
    }
}
