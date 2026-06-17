using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad_de_participantes;
            int puntajes_por_participante;
            int num = 1;
            var numero = 1;
            Console.WriteLine("Le pediremos datos sobre su torneo");
            Console.Write("Cuantos participantes tuvo el torneo?: ");
            cantidad_de_participantes = int.Parse(Console.ReadLine());

            int[] puntos = new int[cantidad_de_participantes];
            for (int i = 0; i < cantidad_de_participantes; i++)
            {
                Console.Write("Dime el puntaje del participante N° " + num + " : ");
                puntajes_por_participante = int.Parse(Console.ReadLine());
                puntos[i] = puntajes_por_participante;
                num++;
            }
            Console.Clear();
            Array.Sort(puntos);
            Array.Reverse(puntos);
            int k = 0;
            Console.WriteLine("La lista de los puntajes de mayor a menor: ");
            Console.WriteLine("");
        
            foreach(int punto in puntos)
            {

                Console.WriteLine("Posicion " + numero + " : " + puntos[k] + " puntos");
                k++;
                numero++;
            }
            Console.WriteLine("");
            Console.WriteLine("El puntaje mas alto registrado fue de " + puntos[0] + " puntos");
            Console.WriteLine(" ");
            Console.WriteLine("El puntaje mas bajo regitrado fue de " + puntos[cantidad_de_participantes - 1] + " puntos");
            Console.ReadKey();
        }
    }
}
