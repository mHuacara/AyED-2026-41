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
            int vida = 1;
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
            while (opcion !=8|| dia<10 && vida>1)
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
                            Console.WriteLine("Y tuviste suerte si encontraste comida");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            cantidad_de_comida_cruda = cantidad_de_comida_cruda + 2;
                            dia++;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Que pena....");
                            Console.WriteLine("No conseguiste nada");
                            Console.WriteLine("Presione una tecla para continuar");
                            dia++;
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
                        if (probabilidad <= 50)
                        {
                            Console.WriteLine("Tuviste suerte encontraste un material util");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            materiales_utiles++;
                            dia++;
                            hambre = hambre - 2;
                        }
                        else if (probabilidad > 50 && probabilidad <= 80)
                        {
                            Console.WriteLine("Lastima no encontraste nada util");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            dia++;
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
                        if (refugio == false && materiales_utiles < 7)
                        {
                            Console.Clear();
                            Console.WriteLine("No tiene materiales suficientes para construir uno");
                            Console.WriteLine("Necesitas al menos 7 materiales utiles");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                        }
                        else if (refugio == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Ya tienes un refugio");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                        }
                        else if (refugio == false && materiales_utiles >= 7)
                        {
                            Console.Clear();
                            Console.WriteLine("Felicidades construiste tu refugio");
                            Console.WriteLine("Pero perdiste una vida por el cansancio");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            dia++;
                            vida--;
                            hambre = hambre - 2;

                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (refugio == false && materiales_utiles > 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Felicidades encendiste tu fogata");
                            Console.WriteLine("Presione una tecla para continuar");
                            fogata = true;
                        }
                        else if (fogata == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Usted ya tiene la fogata encendida");
                            Console.WriteLine("Presione una tecla para continuar");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Necesitas un refugio y al menos dos materiales utiles para encenderla");
                            Console.WriteLine("Presione una tecla para continuar");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        if (fogata = true && cantidad_de_comida_cruda >= 1)
                        {
                            Console.WriteLine("Cocinaste una unidad de comida cruda");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            cantidad_de_comida_cruda--;
                            cantidad_de_comida_cocida++;
                            dia++;
                        }
                        else if (fogata = false || cantidad_de_comida_cruda < 0)
                        {
                            Console.WriteLine("No podes cocinar tu comida,necesitas tener la fogata encendida");
                            Console.WriteLine("Recorda si tenes la fogata encendida para cocinar necesitas al menos UNA UNIDAD de comida cruda");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        if (cantidad_de_comida_cocida >= 1)
                        {
                            Console.WriteLine("Consumite una unidad de comida cocida");
                            Console.WriteLine("Se sumo 4 unidades de hambre");
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione una tecla para continuar");
                            cantidad_de_comida_cocida--;
                            if (hambre == 10)
                            {
                                Console.WriteLine("Tenes las 10 unidades de hambre completas");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione una tecla para continuar");
                            }
                            else if (hambre != 10)
                            {
                                if (hambre >= 7)
                                {
                                    while (hambre < 10)
                                    {
                                        hambre++;
                                    }
                                }
                                else if (hambre <= 6)
                                {
                                    hambre = hambre + 4;
                                }
                            }
                        }
                        break;
                    case 7:
                        Console.Clear();
                        if (refugio == true)
                        {
                            if (vida == 10)
                            {
                                Console.WriteLine("Tiene las 10 unidades de vida completas");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione una tecla para continuar");

                            }
                            if (vida >= 8)
                            {
                                Console.WriteLine("Descansaste,sumaste 3 unidades de vida");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione una tecla para continuar");
                                while (vida < 10)
                                {
                                    vida++;
                                }
                            }
                            else if (vida <= 7)
                            {
                                Console.Write("Descansaste,sumaste 3 unidades de vida");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione una tecla para continuar");
                                vida = vida + 3;
                            }
                        }
                        else
                        {
                            if (vida == 10)
                            {
                                Console.WriteLine("Tiene las 10 unidades de vida completas");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione una tecla para continuar");
                            }
                            else if(vida<10)
                            {
                                Console.WriteLine("Sumo una unidad de vida");
                                Console.WriteLine(" ");
                                Console.WriteLine("Presione una tecla para continuar");
                                vida++;
                            }

                        }
                        break;
                }
                if (vida <=0)
                {
                    vida = 0;
                }
                if(hambre<=0)
                {
                    hambre = 0;
                }
                if (dia == 10 && vida > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Felicidades usted gano el juego");
                    Console.WriteLine(" ");
                    Console.WriteLine("Sus estadisticas: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("DIA: " + dia);
                    Console.WriteLine("VIDA: " + vida);
                    Console.WriteLine("HAMBRE: " + hambre);
                    Console.WriteLine("Cantidad de comida cruda : " + cantidad_de_comida_cruda);
                    Console.WriteLine("Cantidad de comida cocida : " + cantidad_de_comida_cocida);
                    Console.WriteLine("Cantidad de materiales utiles: " + materiales_utiles);
                }
                else if (vida == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Que lastima perdiste =( ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Sus estadisticas: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("DIA: " + dia);
                    Console.WriteLine("VIDA: " + vida);
                    Console.WriteLine("HAMBRE: " + hambre);
                    Console.WriteLine("Cantidad de comida cruda : " + cantidad_de_comida_cruda);
                    Console.WriteLine("Cantidad de comida cocida : " + cantidad_de_comida_cocida);
                    Console.WriteLine("Cantidad de materiales utiles: " + materiales_utiles);
                }

                if (opcion == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Usted salio del juego");
                    Console.WriteLine("Toque una tecla para salir");
                }

                Console.ReadKey();
                

            }
        }
    }
}
