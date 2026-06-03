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
            int numero = 1;
            int total_comida = 0;
            int promedio_de_comida_por_invitado;
            int cantidad_de_invitados;
            int comida_por_invitado;
            Console.WriteLine("Le pediremos que organize la fiesta de invitados de Stitch");
            Console.Write("Cuantos invitados son?: ");
            cantidad_de_invitados = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            while (cantidad_de_invitados < 1 || cantidad_de_invitados >=101)
            {
                Console.WriteLine("Lilo dijo que la cantidad de invitados puede ser de 1 a 100, respeta lo dicho");
                Console.WriteLine("");
                Console.Write("Cuantos invitados estaran en la fiesta?: ");
                comida_por_invitado = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            int[] cantidad_de_comida = new int[cantidad_de_invitados];
            for (int i = 0; i < cantidad_de_invitados; i++)
            {

                Console.Write("Cuanta comida le daras al invitado numero "+numero+" : ");
                cantidad_de_comida[i]= int.Parse(Console.ReadLine());
                if(cantidad_de_comida[i]<1 || cantidad_de_comida[i]>=101)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Recorda que Lilo dijo que lo minimo de comida para cada invitado es 1 y de maximo 100");
                    Console.WriteLine("");
                    Console.Write("Cuanta comida le daras al invitado numero " + numero + " : ");
                    cantidad_de_comida[i] = int.Parse(Console.ReadLine());
                }
                numero++;
            }
            for(int n=0;n<cantidad_de_invitados;n++)
            {
                total_comida = total_comida + cantidad_de_comida[n];
            }
            promedio_de_comida_por_invitado = total_comida / cantidad_de_invitados;
            Console.WriteLine(" ");
            Console.WriteLine("La cantidad de comida promedio por invitado sera de: " + promedio_de_comida_por_invitado);
            Console.ReadKey();
        }
    }
}
