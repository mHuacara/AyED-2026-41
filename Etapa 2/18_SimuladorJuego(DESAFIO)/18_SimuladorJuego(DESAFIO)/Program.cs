using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego_DESAFIO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 10;
            int hambre = 10;
            int dia = 1;
            int cantidad_de_comida_cruda = 0;
            int cantidad_de_comida_cocida = 0;
            int materiales_utiles = 0;
            int opcion = 0;
            bool fogata = false;
            bool refugio = false;
            int probabilidad;
            Console.WriteLine("BIENVENIDO AL JUEGO");
            Console.WriteLine("TRAMA: SOBREVIVE EN LA ISLA");
            Random rand = new Random();
            while (opcion != 8)
            {
                Console.Clear();
                Console.WriteLine("DIA: " + dia);
                Console.WriteLine("VIDA: " + vida);
                Console.WriteLine("HAMBRE: " + hambre);
                Console.WriteLine("Cantidad de comida cruda : " + cantidad_de_comida_cruda);
                Console.WriteLine("Cantidad de comida cocida : " + cantidad_de_comida_cocida);
                Console.WriteLine("Cantidad de materiales utiles: " + materiales_utiles);
                Console.WriteLine(" ");
                Console.WriteLine("Que vas a hacer?¿: ");
                Console.WriteLine(" ");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Explorar la isla");
                Console.WriteLine("3. Construir refugio");
                Console.WriteLine("4. Encender fogata");
                Console.WriteLine("5. Cocinar comida cruda");
                Console.WriteLine("6. Comer comida cruda");
                Console.WriteLine("7. Descansar");
                Console.WriteLine("8. Salir");
                Console.Write("Elige una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Saliste a buscar comida");
               
                        probabilidad = rand.Next(1, 100);
                        if (probabilidad <= 60)
                        {
                            Console.WriteLine("Y tuviste suerte si encontraste");
                            Console.WriteLine("Pero por esta busqueda perdiste un punto de vida por el cansancio");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            cantidad_de_comida_cruda = cantidad_de_comida_cruda + 2;
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Que pena....");
                            Console.WriteLine("No conseguiste nada");
                            Console.WriteLine("Por esta busqueda perdiste un punto de vida por el cansancio");
                            Console.WriteLine("Presione una tecla para continuar");
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Saliste a explorar,con suerte encuentras algo");
                        Console.WriteLine(" ");
                        Console.WriteLine("Yyyyyy....");
                        Console.WriteLine(" ");
                        probabilidad = rand.Next(1, 100);
                        if(probabilidad<=50)
                        {
                            Console.WriteLine("Tuviste suerte encontraste un material util");
                            Console.WriteLine("Pero perdiste una vida por el cansancio");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            materiales_utiles++;
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        else if(probabilidad>50 && probabilidad<=80)
                        {
                            Console.WriteLine("Lastima no encontraste nada util");
                            Console.WriteLine("Y perdiste una vida");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.WriteLine("Uh,tuviste un accidente y te provoco la perdida de dos vidas =( ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            dia++;
                            vida = vida - 2;
                            hambre = hambre - 2;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (refugio==false && materiales_utiles<5)
                        {
                            Console.Clear();
                            Console.WriteLine("No tiene materiales suficientes para construir uno");
                            Console.WriteLine("Necesitas al menos 7 materiales utiles");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                        }
                        else if(refugio==true)
                        {
                            Console.Clear();
                            Console.WriteLine("Ya tienes un refugio");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                        }
                        else if(refugio==false && materiales_utiles>5)
                        {
                            Console.Clear();
                            Console.WriteLine("Felicidades contruiste tu refugio");
                            Console.WriteLine("Pero perdiste una vida por el cansancio");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        break;
                }
                Console.ReadKey();
            }


        }
    }
}
