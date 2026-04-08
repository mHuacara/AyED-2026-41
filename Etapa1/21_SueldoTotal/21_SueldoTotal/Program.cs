using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            float horastrabajadas;
            float valorporhora;
            float sueldototal;
            Console.WriteLine("Le solicitaremos que ponga la cantidad de horas de trabajo y cuando cobra por hora");
            Console.Write("Ponga la cantidad de horas que trabaja: ");
            horastrabajadas = float.Parse(Console.ReadLine());
            Console.Write("Ponga la cantidad que cobra por hora: ");
            valorporhora = float.Parse(Console.ReadLine());
            sueldototal = horastrabajadas * valorporhora;
            Console.Write("Su sueldo total es de: ");
            Console.Write(sueldototal);
            Console.ReadKey();
        }
    }
}
