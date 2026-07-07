using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n;
            int m;
            Console.Write("Dime el valor de n: ");
            n =int.Parse(Console.ReadLine());
            Console.Write("Dime el valor de m: ");
            m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            int[,] matriz1 = new int[n, m];
            int[,] resultante = new int[n, m];
            for(int i=0;i<n;n++)
            {
                for(int j=0;j<m;m++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                    matriz1[i, j] = rand.Next(1, 100);
                    
                }
            }
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    resultante[i, j] = matriz[i, j] + matriz1[i, j];
                }
            }
            Console.WriteLine("Primera matriz: ");
            for (int i = 0; i < n; i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Segunda matriz: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }
            }
                Console.WriteLine("Matriz resultante de la suma de las anteriores matrices: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(resultante[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            Console.ReadKey();
            }


        }
    }

