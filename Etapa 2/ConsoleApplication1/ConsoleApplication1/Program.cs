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
            /*int numero;
            int numero2;
            int numero3;
            Console.WriteLine("dime un numero entero:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("dime un numero entero:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("dime un numero entero:");
            numero3 = int.Parse(Console.ReadLine());
            int[] numeros = new int[3];
            numeros[0] = numero;
 
            numeros[1] = numero2;
            numeros[2] = numero3;
            //for(int i =0;i<numeros.Length;i++)
            
            //foreach (int num in  numeros)
           // {
              //  Console.WriteLine("El número guardado es: " + num);
                //if (numeros[i] > 5)
                // {
                // Console.Write("su numero " + numeros[i] + " ");
                //}

            //}*/
            int[,] matriz = new int[2, 3];
            matriz[0, 0] = 10;
            matriz[0, 1] = 20;
            matriz[1, 2] = 30;
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
