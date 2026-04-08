using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float ancho;
            float altura;
            float perimetro;
            float area;
            double diagonal;
            Console.WriteLine("Tendra que ingresar un ancho y altura para un rectangulo");
            Console.Write("Ingrese el ancho:");
            ancho = float.Parse(Console.ReadLine());
            Console.Write("Ingrese una altura:");
            altura = float.Parse(Console.ReadLine());
            perimetro = 2 * (ancho + altura);
            area = ancho * altura;
            diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(altura, 2));
            Console.Write("El perimetro de su rectangulo es: ");
            Console.WriteLine(perimetro);
            Console.Write("El area de su rectangulo es: ");
            Console.WriteLine(area);
            Console.Write("La diagonal de su rectangulo es: ");
            Console.WriteLine(diagonal);
            Console.ReadKey();

        }
    }
}
