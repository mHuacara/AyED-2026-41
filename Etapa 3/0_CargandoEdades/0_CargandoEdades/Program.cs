using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Le pediremos que ingrese las edades para 5 estudiantes");
            Console.WriteLine("");
            int[] edades = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese la edad del estudiante numero "+num+": ");
                edades[i] = int.Parse(Console.ReadLine());
                num++;
            }
            Console.WriteLine("");
            Console.WriteLine("Edades guardadas: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write( "|"+edades[i] + "|");
            }
            Console.ReadKey();

        }
    }
}
