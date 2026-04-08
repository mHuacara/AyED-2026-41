using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            Console.WriteLine("Le solicitaremos su nombre y apellido");
            Console.Write("Coloque su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Coloque su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Su nombres y apellido es: ");
            Console.Write(nombre);
            Console.Write(" ");
            Console.Write(apellido);
            Console.ReadKey();
        }
        }
    }

