using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CakificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int estudiantes;
            int calificacion;
            Console.Write("Dime una cantidad de estudiantes: ");
            estudiantes = int.Parse(Console.ReadLine());
            Console.Clear();
            string[,] Estudiantes = new string[estudiantes, 3];
            for (int i = 0; i < estudiantes; i++) 
            {
                Console.Write("Dime el nombre del estudiante: ");
                Estudiantes[i, 0] = Console.ReadLine();
                Console.Write("Dime la edad del estudiantes: ");
                Estudiantes[i, 1] = Console.ReadLine();
                Console.Write("Dime la calificacion del estudiante: ");
                Estudiantes[i, 2] = Console.ReadLine();
                calificacion = int.Parse(Estudiantes[i, 2]);
                while(calificacion<0 || calificacion>10)
                {
                    Console.Clear();
                    Console.Write("Dime la calificacion del estudiante: ");
                    Estudiantes[i, 2] = Console.ReadLine();
                    calificacion = int.Parse(Estudiantes[i, 2]);
                }
                Console.Clear();
            }
            Console.WriteLine(" ");
            Console.WriteLine(" Nombre " + " Edad " + " Calificacion ");
            for(int i=0;i<estudiantes;i++)
            {
                Console.WriteLine(" " + Estudiantes[i, 0] + "     " + Estudiantes[i, 1]+"        "+Estudiantes[i,2]);
            }
            Console.ReadKey();
        }
    }
}
