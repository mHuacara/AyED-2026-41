using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int cantidad = 0;
            int[] vidasPokemon = new int[6];
            int numeracion = 1;
            int posicion;
            while (opcion < 13)
            {
                opcion = 0;
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("C E N T R O P O K É - R E M E D I O");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Elija una opcióbn: ");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1- Registrar un nuevo pokemón");
                Console.WriteLine("2- Mostrar la vida de todos los pokemones");
                Console.WriteLine("3- Curar un pokemón");
                Console.WriteLine("4- Dañar un pokemon");
                Console.WriteLine("5- Curar a todos los pokemones");
                Console.WriteLine("6- Mostrar pokemones debilitados");
                Console.WriteLine("7- Mostrar el pokemon con mayor vida");
                Console.WriteLine("8- Mostrar el pokemon con menor vida");
                Console.WriteLine("9- Calcular promedio de vida del equipo");
                Console.WriteLine(" ");
                Console.Write("Que opcion deseas hacer?: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cantidad < 6)
                        {
                            Console.Clear();
                        Console.Write("Ingrese la vida del pokemon: ");
                        vidasPokemon[cantidad] = int.Parse(Console.ReadLine());
                        int vida = vidasPokemon[cantidad];
                            while (vida < 0 || vida > 100)
                            {
                                Console.WriteLine("Registre nuevamente la vida del pokemon, no puede ser menor que 0 o mayor que 100");
                                Console.Write("Ingrese la vida del pokemon: ");
                                vidasPokemon[cantidad] = int.Parse(Console.ReadLine());
                                vida = vidasPokemon[cantidad];
                                Console.Clear();
                            }

                            Console.WriteLine("Pokemon registrado correctamente en la posicion " + numeracion);
                            cantidad++;
                            numeracion++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No se pueden registrar mas pokemones.El centro esta lleno");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Vida de los pokemones registrados: ");
                        Console.WriteLine("");
                        for(int i=0;i<cantidad;i++)
                        {
                            Console.WriteLine("Pokemon " + (i+1) + " -Vida: " + vidasPokemon[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        int curacion;
                        Console.WriteLine("Ingrese la posicion(0-5) del pokemon que desea curar");
                        posicion = int.Parse(Console.ReadLine());
                        while(posicion>=6 || posicion<0)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingresa una posicion valida!");
                            Console.WriteLine("");
                            Console.Write("Ingrese la posicion del pokemon que desea curar: ");
                            posicion = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Ingrese puntos de vida a recuperar: ");
                        curacion = int.Parse(Console.ReadLine());
                        vidasPokemon[posicion] += curacion;
                        if (vidasPokemon[posicion] >= 100)
                        {
                            vidasPokemon[posicion] = 100;
                        }
                        Console.WriteLine("Vida actual del pokemon: " + vidasPokemon[posicion]);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        int daño;
                        Console.Write("Ingrese la posicion del pokemon atacado: ");
                        posicion = int.Parse(Console.ReadLine());
                        while (posicion >= 6 || posicion < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Ingresa una posicion valida!");
                            Console.WriteLine("");
                            Console.Write("Ingrese la posicion del pokemon que desea curar: ");
                            posicion = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Ingrese daño recibido: ");
                        daño = int.Parse(Console.ReadLine());
                        vidasPokemon[posicion] -= daño;
                        if(vidasPokemon[posicion]<0)
                        {
                            vidasPokemon[posicion] = 0;
                        }
                        Console.WriteLine("Vida actual del pokemon: " + vidasPokemon[posicion]);
                        Console.ReadKey();
                        break;
                    case 6:

                    
                }

            }
            Console.ReadKey();
        }
    }
}
