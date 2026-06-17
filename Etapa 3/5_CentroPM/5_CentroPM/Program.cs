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
            int vida;
            int num;

            Console.WriteLine("¡Bienvenido al Centro Poke-Remedio!");
            Console.WriteLine("Que opcion eliges?: ");
            num = int.Parse(Console.ReadLine());
            while(num<13)
            {
                switch(num)
                {
                    case 1:
                        Console.WriteLine("Registrar un nuevo pokémon");
                        int[] vidasPokemones = new int[6];
                        for(int i=0;i<6;i++)
                        {
                            Console.WriteLine("Ingrese la vida del pokemon: ");
                            vida = int.Parse(Console.ReadLine());
                            if(vida>=1 && vida<=100)
                            {
                                vidasPokemones[i] = vida;
                            }
                            else
                            {

                            }
                           
                        }
                        break;
                    case 2:
                        Console.WriteLine("Mostrar la vida de todos los pokemones");
                        break;
                    case 3:
                        Console.WriteLine("Curar un pokémon");
                        break;
                    case 4:
                        Console.WriteLine("Dañar un pokémon");
                        break;
                    case 5:
                        Console.WriteLine("Curar a todos los pokemones");
                        break;
                    case 6:
                        Console.WriteLine("Mostrar pokemones debilitados");
                        break;
                    case 7:
                        Console.WriteLine("Mostrar pokemones debilitados");
                        break;
                    case 8:
                        Console.WriteLine("Mostrar el pokémon con menor vida");
                        break;
                    case 9:
                        Console.WriteLine("Calcular promedio de vida del equipo");
                        break;
                    case 10:
                        Console.WriteLine("Ordenar pokemones por vida de menor a mayor");
                        break;
                    case 11:
                        Console.WriteLine("Ordenar pokemones por vida de mayor a menor");
                        break;
                    case 12:
                        Console.WriteLine("Simular ataque enemigo a todo el equipo");
                        break;
                    case 13:
                        Console.WriteLine("Salir");
                        break;



                }
            }



        }
    }
}
