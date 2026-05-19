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
            string fogata_estado = "Apagado";
            string refugio_estado = "No construido";
            int probabilidad;
            bool victoria = false;
            bool derrota = false;
            Console.WriteLine("BIENVENIDO AL JUEGO");
            Console.WriteLine("TRAMA: SOBREVIVE EN LA ISLA");
            Random rand = new Random();
            while (opcion != 8 && victoria == false && derrota == false)
            {
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("SUPERVIVENCIA EN LA ISLA");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("DIA: " + dia);
                Console.WriteLine("VIDA: " + vida);
                Console.WriteLine("HAMBRE: " + hambre);
                Console.WriteLine("Cantidad de comida cruda : " + cantidad_de_comida_cruda);
                Console.WriteLine("Cantidad de comida cocida : " + cantidad_de_comida_cocida);
                Console.WriteLine("Cantidad de materiales utiles: " + materiales_utiles);
                Console.WriteLine("Fogata: " + fogata_estado);
                Console.WriteLine("Refugio: " + refugio_estado);
                Console.WriteLine(" ");
                Console.WriteLine("Que vas a hacer?¿: ");
                Console.WriteLine(" ");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Explorar la isla");
                Console.WriteLine("3. Construir refugio");
                Console.WriteLine("4. Encender fogata");
                Console.WriteLine("5. Cocinar comida cruda");
                Console.WriteLine("6. Comer comida cocida");
                Console.WriteLine("7. Descansar");
                Console.WriteLine("8. Salir");
                Console.Write("Elige una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Saliste a buscar comida");
                        Console.WriteLine(" ");
                        probabilidad = rand.Next(1, 101);
                        if (probabilidad <= 60)
                        {
                            Console.WriteLine("Y tuviste suerte si encontraste comida");
                            Console.WriteLine("Pero perdiste una vida por la busqueda");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            vida--;
                            cantidad_de_comida_cruda = cantidad_de_comida_cruda + 2;
                            dia++;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Que pena....");
                            Console.WriteLine("No conseguiste nada");
                            Console.WriteLine(" ");
                            Console.WriteLine("Y perdiste un punto de vida por la busqueda");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            vida--;
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
                            Console.WriteLine("Tuviste suerte encontraste un materiales utiles");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            materiales_utiles = materiales_utiles + 3;
                            dia++;
                            hambre = hambre - 2;
                        }
                        else if (probabilidad > 50 && probabilidad <= 80)
                        {
                            Console.WriteLine("Lastima no encontraste nada util");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            dia++;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.WriteLine("Uh,tuviste un accidente y te provoco la perdida de dos vidas =( ");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            dia++;
                            vida = vida - 2;
                            hambre = hambre - 2;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (refugio == false && materiales_utiles <5)
                        {
                            Console.Clear();
                            Console.WriteLine("No tiene materiales suficientes para construir uno");
                            Console.WriteLine("Necesitas al menos 5 materiales utiles");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            
                        }
                        else if (refugio == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Ya tienes un refugio");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
  
                        }
                        else if (refugio == false && materiales_utiles >=5)
                        {
                            Console.Clear();
                            Console.WriteLine("Felicidades construiste tu refugio");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            dia++;
                            hambre = hambre - 2;
                            refugio = true;
                            refugio_estado = "Construido";
                            materiales_utiles = materiales_utiles - 5;

                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (refugio == true && materiales_utiles >= 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Felicidades encendiste tu fogata");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            dia++;
                            hambre = hambre - 2;
                            fogata = true;
                            fogata_estado = "Encendido";
                            materiales_utiles = materiales_utiles - 2;
                        }
                        else if (fogata == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Usted ya tiene la fogata encendida");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                           
                        }
                        else if(refugio==false || materiales_utiles<2)
                        {
                            Console.Clear();
                            Console.WriteLine("Necesitas un refugio y al menos dos materiales utiles para encenderla");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                           
                        }
                        break;
                    case 5:
                        Console.Clear();
                        if (fogata == true && cantidad_de_comida_cruda >= 1)
                        {
                            Console.WriteLine("Cocinaste una unidad de comida cruda");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            cantidad_de_comida_cruda--;
                            cantidad_de_comida_cocida++;
                        }
                        else if(fogata==true && cantidad_de_comida_cruda<=0)
                        {
                            Console.WriteLine("No tiene unidades de comida cruda para cocinar");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                        }
                       else if(fogata==false && cantidad_de_comida_cruda>=1)
                        {
                            Console.WriteLine("Debes tener la fogata encendida para cocinar tu comida cruda");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        if (cantidad_de_comida_cocida >= 1)
                        {
                            Console.WriteLine("Consumite una unidad de comida cocida");
                            Console.WriteLine("Se sumo 4 unidades de hambre");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                            cantidad_de_comida_cocida--;
                            if (hambre == 10)
                            {
                                Console.WriteLine("Tenes las 10 unidades de hambre completas");
                                Console.WriteLine(" ");
                                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                                
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
                        else if(cantidad_de_comida_cocida==0)
                        {
                            Console.WriteLine("No tienes unidades de comida cocida para consumir");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
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
                                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                                dia++;
                              

                            }
                            else if (vida >= 8)
                            {
                                Console.WriteLine("Descansaste,sumaste 3 unidades de vida");
                                Console.WriteLine(" ");
                                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                                dia++;
                                while (vida < 10)
                                {
                                    vida++;
                                }
                            }
                            else if (vida <= 7)
                            {
                                Console.WriteLine("Descansaste,sumaste 3 unidades de vida");
                                Console.WriteLine(" ");
                                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                                dia++;
                                vida = vida + 3;
                            }
                        }
                        else
                        {
                            if (vida == 10)
                            {
                                Console.WriteLine("Tiene las 10 unidades de vida completas");
                                Console.WriteLine(" ");
                                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                                
                            }
                            else if(vida<10)
                            {
                                Console.WriteLine("Descansaste y sumaste una unidad de vida");
                                Console.WriteLine(" ");
                                Console.WriteLine("SI TENES REFUGIO TE RECUPERAN 3 UNIDADES DE VIDA");
                                Console.WriteLine(" ");
                                Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR");
                                dia++;
                                vida++;
                            }

                        }
                        break;
                }
                if (hambre <= 0)
                {
                    hambre = 0;
                    vida = vida - 2;
                }
                if (vida <=0)
                {
                    vida = 0;
                }
                if (dia == 10 && vida > 0)
                {
                    Console.Clear();
                    Console.WriteLine("VICTORIA");
                    Console.WriteLine(" ");
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
                    Console.WriteLine("Fogata: " + fogata_estado);
                    Console.WriteLine("Refugio: " + refugio_estado);
                    Console.WriteLine(" ");
                    Console.WriteLine("TOQUE UNA TECLA PARA SALIR");

                    victoria = true;
                }
                else if (vida == 0)
                {
                    Console.Clear();
                    Console.WriteLine("DERROTA");
                    Console.WriteLine(" ");
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
                    Console.WriteLine("Fogata: " + fogata_estado);
                    Console.WriteLine("Refugio: " + refugio_estado);
                    Console.WriteLine(" ");
                    Console.WriteLine("TOQUE UNA TECLA PARA SALIR");
                 
                    derrota = true;
                }

                if (opcion == 8)
                {
                    Console.Clear();
                    Console.WriteLine("Usted salio del juego");
                    Console.WriteLine(" ");
                    Console.WriteLine("Sus estadisticas: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("DIA: " + dia);
                    Console.WriteLine("VIDA: " + vida);
                    Console.WriteLine("HAMBRE: " + hambre);
                    Console.WriteLine("Cantidad de comida cruda : " + cantidad_de_comida_cruda);
                    Console.WriteLine("Cantidad de comida cocida : " + cantidad_de_comida_cocida);
                    Console.WriteLine("Cantidad de materiales utiles: " + materiales_utiles);
                    Console.WriteLine("Fogata: " + fogata_estado);
                    Console.WriteLine("Refugio: " + refugio_estado);
                    Console.WriteLine(" ");
                    Console.WriteLine("TOQUE UNA TECLA PARA SALIR");
                }

                Console.ReadKey();
                

            }
        }
    }
}
