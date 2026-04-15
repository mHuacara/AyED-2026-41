using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Le preguntaremos un numero entero y le diremos si es par o impar");
            Console.Write("Diga un numero: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.Write("Su numero es par");
            }
            else
            {
                Console.Write("Su numero es impar");
            }
            Console.ReadKey();
            //No pasa nada ya que el 0 cumple con la condicion de que si lo divides con 2 el resto da 0 y cumple la condicion
        }
    }
}
