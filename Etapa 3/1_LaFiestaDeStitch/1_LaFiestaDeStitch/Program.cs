using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio_de_comida_por_invitado;
            int cantidad_de_invitados;
            int cantidad_de_comida;
            int comida_por_invitado;
            Console.WriteLine("Le pediremos que organize la fiesta de invitados de Stitch");
            Console.WriteLine("Cuantos invitados son?: ");
            cantidad_de_invitados = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanta comida daras a cada invitado?: ");
            comida_por_invitado = int.Parse(Console.ReadLine());
            while (comida_por_invitado < 1 || comida_por_invitado > 100)
            {
                Console.WriteLine("Lilo dijo que la cantidad de comida puede ser de 1 a 100 respeta lo dicho");
                Console.WriteLine("");
                Console.WriteLine("Cuanta comida daras a cada invitado?: ");
                comida_por_invitado = int.Parse(Console.ReadLine());
            }
            cantidad_de_comida = comida_por_invitado * cantidad_de_invitados;
            promedio_de_comida_por_invitado = cantidad_de_comida / cantidad_de_invitados;
            Console.WriteLine("Cantidad promedio de comida para cada invitado"+promedio_de_comida_por_invitado);
            Console.ReadKey();
        }
    }
}
