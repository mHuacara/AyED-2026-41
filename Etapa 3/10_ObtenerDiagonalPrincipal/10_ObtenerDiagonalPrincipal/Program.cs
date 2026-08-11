using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamaño;
            Random rand = new Random();
            Console.Write("Dime un tamaño para una matriz: ");
            tamaño = int.Parse(Console.ReadLine());
            int[,] matriz = new int[tamaño, tamaño];
            int[] diagonal_principal = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Matriz: ");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < tamaño; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }
            for (int i = 0; i < tamaño; i++)
            {
                diagonal_principal[i] = matriz[i, i]; 
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write(diagonal_principal[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
