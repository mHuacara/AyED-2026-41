using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida;
            int num = 0;
            int[] vidaPókemones = new int[6];
            int i = 0;
            int cantidad = 0;
            while (num < 13)
            {
                Console.WriteLine("¡Bienvenido al Centro Poke-Remedio!");
                Console.WriteLine("");
                Console.WriteLine("Te daremos opciones para elegir");
                Console.WriteLine("");
                Console.WriteLine("1. Registrar un nuevo pokémon");
                Console.WriteLine("2. Mostrar la vida de todos los pokemones");
                Console.WriteLine("3. Curar un pokémon");
                Console.WriteLine("4. Dañar un pokémon");
                Console.WriteLine("5. Curar a todos los pokemones");
                Console.WriteLine("6. Mostrar pokemones debilitados");
                Console.WriteLine("7. Mostrar el pokemon con mayor vida");
                Console.WriteLine("8. Mostar el pokemon con menor vida");
                Console.WriteLine("9. Calcular el promedio de vida del equipo");
                Console.WriteLine("10. Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("11. Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("12. Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13.Salir");
                Console.WriteLine(" ");
                Console.Write("Que opcion vas a elegir?: ");
                num = int.Parse(Console.ReadLine());

                {
                    switch (num)
                    {
                        case 1:

                            if (cantidad < 6)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ingrese la vida del pokemon: ");
                                    vidaPókemones[i] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Pokemon registrado correctamente en la posicion " + i);
                                    i++;
                                    cantidad++;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("No se puede registar mas pokemones. El centro esta lleno");
                                }
                                break;

                        case 2:
                            int posicion = 1;
                            for (int h = 0; h < vidaPókemones.Length; h++)
                            {
                                Console.WriteLine("Pokemon " + posicion + " - Vida: " + vidaPókemones[h]);
                                posicion++;
                            }
                             break;
                        case 3:
                            int puntos;
                            int lugar;
                            Console.Write("Ingresa la posicion del pokemon que deseas curar: ");
                            lugar = int.Parse(Console.ReadLine());
                            Console.Write("Cuantos puntos de vida quieres que recupere?: ");


                        


                    }
                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
