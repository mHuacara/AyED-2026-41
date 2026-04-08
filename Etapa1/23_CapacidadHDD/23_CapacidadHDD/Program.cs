using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            float cantidaddecilindros;
            float pistasporcilindro;
            float sectoresporpistadeundiscoduro;
            float kilobytes;
            float megabytes;
            float gigabytes;
            Console.WriteLine("Le solicitaremos una cantidad de cilindros,pistas por cilindro y sectores por pista de un disco duro");
            Console.Write("Ponga una cantidad de cilindros: ");
            cantidaddecilindros = float.Parse(Console.ReadLine());
            Console.Write("Ponga una cantidad de pistas por cilindro: ");
            pistasporcilindro = float.Parse(Console.ReadLine());
            Console.Write("Ponga una cantidad de sectores por pista de un disco duro: ");
            sectoresporpistadeundiscoduro = float.Parse(Console.ReadLine());
            kilobytes = (512 * cantidaddecilindros * pistasporcilindro * sectoresporpistadeundiscoduro) / 1000;
            megabytes = (512 * cantidaddecilindros * pistasporcilindro * sectoresporpistadeundiscoduro) / 1000000;
            gigabytes = (512 * cantidaddecilindros * pistasporcilindro * sectoresporpistadeundiscoduro) / 1000000000;
            Console.Write("Su cantidad en kilobytes es de: ");
            Console.WriteLine(kilobytes);
            Console.Write("Su cantidad en megabytes es de: ");
            Console.WriteLine(megabytes);
            Console.Write("Su cantidad en gigabytes es de: ");
            Console.WriteLine(gigabytes);
            Console.ReadKey();
        }
    }
}
