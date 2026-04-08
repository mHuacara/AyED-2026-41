using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float ancho;
            float altura;
            float area;
            Console.WriteLine("Le solicitaremos la base y altura de un triangulo");
            Console.Write("Dime la base de un triangulo: ");
            ancho = float.Parse(Console.ReadLine());
            Console.Write("Dime la altura de un triangulo: ");
            altura = float.Parse(Console.ReadLine());
            area = (ancho * altura) / 2;
            Console.Write("El area de su triangulo es de: ");
            Console.WriteLine(area);
            Console.ReadKey();


        }
    }
}
