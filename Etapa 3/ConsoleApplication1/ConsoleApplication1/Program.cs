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
            int[,] ñiñiñiñi = {
               { 20, 12, 3, 8, 1},
               { 73, 49, 17, 98, 40},
               { 25, 84, 63, 59, 37},
               { 10, 60, 78, 91, 2}
             };

            int filas = ñiñiñiñi.GetLength(0);
            int columnas = ñiñiñiñi.GetLength(1);

            int[] arregloAplanado = new int[filas * columnas];
            int indice = 0;


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                  Console.WriteLine(arregloAplanado[indice] = ñiñiñiñi[i, j] indice++);
                    
                }


            }
           Console.ReadKey();
        }
    }

}
