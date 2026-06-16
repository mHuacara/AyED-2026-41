using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad_de_productos;
            int precio_por_producto;
            int num = 1;
            Console.WriteLine("Te pediremos la lista de productos vendidos durante el Hot Sale");
            Console.Write("Cuantos productos se vendieron en el festival?: ");
            cantidad_de_productos = int.Parse(Console.ReadLine());

            int[] precios = new int[cantidad_de_productos];
            for(int i=0; i<cantidad_de_productos; i++)
            {
                Console.Write("Dime el precio(numero entero) del producto numero "+num+" : " );
                precio_por_producto = int.Parse(Console.ReadLine());
                precios[i] = precio_por_producto;
                num++;
            }
            Array.Sort(precios);
            Console.WriteLine("El producto mas barato vendido fue de " + precios[0]+" $");
            Console.WriteLine("El producto mas caro vendido fue de " + precios[cantidad_de_productos-1] + " $");
            Console.ReadKey();
        }
    }
}
