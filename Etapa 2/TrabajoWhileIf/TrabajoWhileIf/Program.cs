using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoWhileIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;
            float op31;
            float op32;
            float total;
            Console.WriteLine("Le pediremos un numero entero del 1 al 5 para elegir las siguientes opciones: ");
            Console.WriteLine();
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.WriteLine();
            Console.WriteLine("1. Hola Mundo!");
            Console.WriteLine("2. Adios");
            Console.WriteLine("3. Una suma de dos numeros a tu eleccion");
            Console.WriteLine("4. Usted selecciono 4");
            Console.WriteLine("5. SALIR");
            Console.WriteLine();
            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
            Console.WriteLine();
            Console.Write("Que numero desea poner?: ");
            numero = int.Parse(Console.ReadLine());
            while (numero < 6 && contador==0 && numero>=1)
            {
                if(numero==1)
                {
                    Console.Clear();
                    Console.WriteLine("Hola mundo!");
                    contador++;
                }
                if(numero==2)
                {
                    Console.Clear();
                    Console.WriteLine("Adios");
                    contador++;
                }
                if(numero==3)
                {
                    Console.Clear();
                    Console.WriteLine("Le pediremos dos numeros");
                    Console.Write("Escriba su primer numero: ");
                    op31 = float.Parse(Console.ReadLine());
                    Console.Write("Escriba un segundo numero: ");
                    op32 = float.Parse(Console.ReadLine());
                    total = op31 + op32;
                    Console.Write("La suma de sus numeros da " + total);
                    contador++;
                 }
                if(numero==4)
                {
                    Console.Clear();
                    Console.WriteLine("Usted selecciono la opcion 4");
                    contador++;
                }
                if (numero == 5)
                {
                    Console.Clear();
                    Console.Write("Salio del programa");
                    contador++;
                }
            }
            if (numero >= 6 || numero <= 0)
            {
                Console.Clear();
                while (contador < 32)
                {
                    Console.WriteLine("ERROR");
                    contador++;
                }
            }
            Console.ReadKey();
        }
    }
}
