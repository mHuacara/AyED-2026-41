using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 0;
            while (numero < 100)
            {

                numero++;
                if (numero % 3 == 0 && numero % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (numero % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (numero % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(numero);
                }
      
            }
            Console.ReadKey();

        }
    }
}

