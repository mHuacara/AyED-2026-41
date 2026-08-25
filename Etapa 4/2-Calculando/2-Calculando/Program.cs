using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
         calculadora(2, 8, 3);
         Console.ReadKey();
        }
        static int suma(int a,int b)
        {
            return a + b;
        }
        static int resta(int a, int b)
        {
            return a - b;
        }
        static int multiplicacion(int a,int b)
        {
            return a * b;
        }
        static double division(double a,double b)
        {
            return a / b;
        }
        static void calculadora(int opcion,int a,int b)
        {
            switch (opcion)
            {
                case 1:
                    Console.Write(suma(a, b));
                    break;
                case 2:
                    Console.WriteLine(resta(a, b));
                    break;
                case 3:
                    Console.WriteLine(multiplicacion(a, b));
                    break;
                case 4:
                    Console.WriteLine(division(a, b));
                    break;

            }
        }
    }
}
