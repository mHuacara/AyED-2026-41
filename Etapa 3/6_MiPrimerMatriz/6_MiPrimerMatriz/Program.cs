using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            int valor = 0;
            Console.Write("Dime el valor de m: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Dime el valor de n: ");
            n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n,m];
            for (int i=0; i<n;i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = 0;
                }
            }
            Console.WriteLine("Matriz: ");
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();

            

        }
    }
}
