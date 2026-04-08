using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            int horas;
            int minutosrestantes;
            Console.WriteLine("Le solicitaremos una cantidad de minutos");
            Console.Write("Digame una cantidad de minutos: ");
            minutos = int.Parse(Console.ReadLine());
            horas = minutos / 60;
            minutosrestantes = minutos % 60;
            Console.Write("Sus minutos equivalen a " + horas + " horas con " + minutosrestantes + " minutos");
            Console.ReadKey();
        }
    }
}
