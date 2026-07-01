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
            int numeracion = 0;
            int posicion;
            int probabilidad;
            bool estado = false;
            Random rand = new Random();

            while (opcion < 13)
            {
                posicion = 0;
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
                Console.WriteLine("10- Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("11_ Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("12- Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13- Salir");
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
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Pokemon " + (i + 1) + " -Vida: " + vidasPokemon[i]);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (cantidad != 0)
                        {
                            int curacion;
                            Console.WriteLine("Ingrese la posicion(0-5) del pokemon que desea curar");
                            posicion = int.Parse(Console.ReadLine());

                            while (posicion >= 6 || posicion < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingresa una posicion valida!");
                                Console.WriteLine("");
                                Console.Write("Ingrese la posicion del pokemon que desea curar: ");
                                posicion = int.Parse(Console.ReadLine());
                            }
                            /*else if(cantidad!=0)
                            {
                                Console.WriteLine("No tienes pokemones registrados");
                            }*/
                            Console.Write("Ingrese puntos de vida a recuperar: ");
                            curacion = int.Parse(Console.ReadLine());
                            vidasPokemon[posicion] += curacion;
                            if (vidasPokemon[posicion] >= 100)
                            {
                                vidasPokemon[posicion] = 100;
                            }
                            Console.WriteLine("Vida actual del pokemon: " + vidasPokemon[posicion]);
                        }
                        else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        if (cantidad != 0)
                        {
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
                            if (vidasPokemon[posicion] < 0)
                            {
                                vidasPokemon[posicion] = 0;
                            }
                            Console.WriteLine("Vida actual del pokemon: " + vidasPokemon[posicion]);
                        }
                        else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ingrese puntos de una curacion general: ");
                        int curacion_general = int.Parse(Console.ReadLine());
                        for (int h = 0; h < cantidad; h++)
                        {
                            vidasPokemon[h] += curacion_general;
                            if (vidasPokemon[h] > 100)
                            {
                                vidasPokemon[h] = 100;
                            }
                            Console.WriteLine("Todos los pokemones fueron curados");
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        if (cantidad != 0)
                        {
                            int pokemones_con_vida_0 = 0;
                            for (int k = 0; k < cantidad; k++)
                            {
                                if (vidasPokemon[k] == 0)
                                {
                                    estado = true;
                                }

                            }
                            if (estado == true)
                            {
                                Console.WriteLine("Pokemones debilitados: ");
                                Console.WriteLine(" ");
                                for (int m = 0; m < cantidad; m++)
                                {
                                    if (vidasPokemon[m] == 0)
                                    {
                                        Console.WriteLine("Pokemon debilitado en la posicion " + m);
                                        pokemones_con_vida_0++;
                                    }
                                }
                                Console.WriteLine(" ");
                                Console.WriteLine("Cantidad total de debilitados " + pokemones_con_vida_0);
                            }
                            else
                            {
                                Console.WriteLine("No hay pokemones debilitados");
                            }
                        }
                        else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        if(cantidad!=0)
                        { 
                        int vida_mayor = 0;
                        for (int m = 0; m < cantidad; m++)
                        {
                            if (vidasPokemon[m] > vida_mayor)
                            {
                                vida_mayor = vidasPokemon[m];
                                posicion = m;
                            }
                        }
                        Console.WriteLine("El pokemon con mayor vida esta en la posicion " + posicion);
                        Console.WriteLine("Vida: " + vida_mayor);
                         }
                          else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.Clear();
                        if (cantidad != 0)
                        {
                            int vida_menor = 100;
                            for (int z = 0; z < cantidad; z++)
                            {
                                if (vidasPokemon[z] < vida_menor)
                                {
                                    vida_menor = vidasPokemon[z];
                                    posicion = z;
                                }
                            }
                            Console.WriteLine("El pokemon con menor vida esta en la posicion " + posicion);
                            Console.WriteLine("Vida: " + vida_menor);
                        }
                        else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;

                    case 9:
                        Console.Clear()
                        if (cantidad != 0)
                        {
                            int vida_grupal = 0;
                            for (int v = 0; v < cantidad; v++)
                            {
                                vida_grupal += vidasPokemon[v];
                            }
                            int promedio = vida_grupal / cantidad;
                            if (promedio >= 70)
                            {
                                Console.WriteLine("El equipo esta en buen estado");
                                Console.WriteLine("Promedio de vida del equipo: " + promedio);
                            }
                            else if (promedio >= 31 && promedio <= 69)
                            {
                                Console.WriteLine("El equipo necesita recuperacion");
                                Console.WriteLine("Promedio de vida del equipo: " + promedio);
                            }
                            else
                            {
                                Console.WriteLine("El equipo esta en peligro");
                                Console.WriteLine("Promedio de vida del equipo: " + promedio);
                            }
                        }
                        else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        if (cantidad != 0)
                        {
                            Console.WriteLine("Vidas ordenadas de menor a mayor");
                            Array.Sort(vidasPokemon, 0, cantidad);
                            for (int w = 0; w < cantidad; w++)
                            {
                                Console.WriteLine(vidasPokemon[w]);
                            }
                        }
                        else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        if (cantidad != 0) 
                        {
                            Array.Sort(vidasPokemon, 0, cantidad);
                            Array.Reverse(vidasPokemon, 0, cantidad);
                            Console.WriteLine("Vidas ordenadas de mayor a menor");
                            for (int f = 0; f < cantidad; f++)
                            {
                                Console.WriteLine(vidasPokemon[f]);
                            }
                        }
                        else if (cantidad == 0)
                        {
                            Console.WriteLine("No tienes pokemones registrados");
                        }
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        probabilidad = rand.Next(5, 25);
                        for(int y=0;y<cantidad;y++)
                        {
                            vidasPokemon[y] -= probabilidad;
                            if(vidasPokemon[y]<0)
                            {
                                vidasPokemon[y] = 0;
                            }
                        }
                        Console.WriteLine("¡Un pokemon salvaje ataco al equipo!");
                        Console.WriteLine("Daño recibido por todos: " + probabilidad);
                        Console.WriteLine(" ");
                        Console.WriteLine("Las vidas fueron actualizadas");
                        Console.ReadKey();
                        break;
                }
            }
            if (opcion == 13)
            {
                Console.Clear();
                Console.WriteLine("Gracias por utilizar el sistema Centro Poke-Remedio");

            }
            Console.ReadKey();
        }
    }
}
