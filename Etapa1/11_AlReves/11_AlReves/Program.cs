using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            string letras;
            
            Console.WriteLine("Tendra que poner tres letras");
            Console.Write("Dime tres letras: ");
            letras = Console.ReadLine();
            Console.Write("Su orden inverso: ");
            Console.Write(letras[2]);
            Console.Write(letras[1]);
            Console.Write(letras[0]);
            Console.ReadKey();
            


        }
    }
    }

