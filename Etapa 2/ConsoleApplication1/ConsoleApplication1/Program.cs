using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int consulta;
            int[] numero = { 2, 4, 6, 8, 10, 12, 14, 16 };
            Console.WriteLine("Le pediremos un numero y le diremos si esta en la lista o no");
            Console.WriteLine("Escriba un numero entero: ");
            consulta = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero.Length; i++)
            {
                if (consulta == numero[i])
                {
                    Console.WriteLine("Su numero si esta en la lista y en la posicion " + i);
                }
                if (consulta != numero[i])
                {
                    while (contador < 1)
                    {
                        Console.WriteLine("Su numero no esta en la lista");
                        contador++;
                    }
                }




                Console.ReadKey();
            }
        }
    }
}
