using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            string ciudad;
            Console.WriteLine("Le solicitaremos su nombre,edad y en la ciudad que se encuentra");
            Console.Write("Coloque su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Coloque su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Coloque en la ciudad que se encuentra: ");
            ciudad = Console.ReadLine();
            Console.Write("Usted se llama "+nombre+" y su edad es de "+edad+" y se ubica en la ciudad de "+ciudad);
            Console.ReadKey();
        }
    }
}
