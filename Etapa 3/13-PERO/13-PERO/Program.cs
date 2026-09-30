using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_PERO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            string[,] misiones = new string[30, 5];

            int cantidad = 0;
            int id = 1;
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de pegrilo por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cantidad < 30)
                        {
                            misiones[cantidad, 0] = id.ToString();

                            bool mapaValido = false;

                            while (mapaValido == false)
                            {
                                Console.Write("Ingrese el mapa (1-Hagwarts, 2-La Casa del Viejo, 3-El Laboratorio): ");
                                int mapa = int.Parse(Console.ReadLine());

                                if (mapa >= 1 && mapa <= 3)
                                {
                                    misiones[cantidad, 1] = mapa.ToString();
                                    mapaValido = true;
                                }
                                else
                                {
                                    Console.WriteLine("Ese mapa no es de este juegazo.");
                                }
                            }

                            int objetos = rand.Next(1, 71);
                            misiones[cantidad, 2] = objetos.ToString();

                            bool peligroValido = false;

                            while (peligroValido == false)
                            {
                                Console.Write("Ingrese el nivel de peligro (1 a 5): ");
                                int peligro = int.Parse(Console.ReadLine());

                                if (peligro >= 1 && peligro <= 5)
                                {
                                    misiones[cantidad, 3] = peligro.ToString();
                                    peligroValido = true;
                                }
                                else
                                {
                                    Console.WriteLine("Este nivel es demasiado PEGRILOSO...");
                                }
                            }

                            misiones[cantidad, 4] = "0";

                            Console.WriteLine();
                            Console.WriteLine("Misión registrada:");
                            Console.WriteLine("ID: " + misiones[cantidad, 0]);
                            Console.WriteLine("Mapa: " + misiones[cantidad, 1]);
                            Console.WriteLine("Objetos a extraer: " + misiones[cantidad, 2]);
                            Console.WriteLine("Nivel de peligro: " + misiones[cantidad, 3]);
                            Console.WriteLine("Estado: Pendiente");

                            cantidad++;
                            id++;
                        }
                        else
                        {
                            Console.WriteLine("¡Demasiadas misiones!");
                        }

                        break;

                    case 2:
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay misiones registradas.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine("Misión " + misiones[i, 0]);

                                if (misiones[i, 1] == "1")
                                {
                                    Console.WriteLine("Mapa: Hagwarts");
                                }
                                else if (misiones[i, 1] == "2")
                                {
                                    Console.WriteLine("Mapa: La Casa del Viejo");
                                }
                                else
                                {
                                    Console.WriteLine("Mapa: El Laboratorio");
                                }

                                Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);

                                if (misiones[i, 4] == "0")
                                {
                                    Console.WriteLine("Estado: Pendiente");
                                }
                                else if (misiones[i, 4] == "1")
                                {
                                    Console.WriteLine("Estado: En Curso");
                                }
                                else
                                {
                                    Console.WriteLine("Estado: Finalizado");
                                }

                                Console.WriteLine("-------------------------");
                            }
                        }

                        break;

                    case 3:
                        Console.Write("Ingrese el ID de la misión: ");
                        int idBuscar = int.Parse(Console.ReadLine());

                        bool encontrada = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (misiones[i, 0] == idBuscar.ToString())
                            {
                                encontrada = true;

                                if (misiones[i, 4] == "0")
                                {
                                    misiones[i, 4] = "1";
                                    Console.WriteLine("La misión ahora está En Curso.");
                                }
                                else if (misiones[i, 4] == "1")
                                {
                                    misiones[i, 4] = "2";
                                    Console.WriteLine("La misión ahora está Finalizada.");
                                }
                                else
                                {
                                    Console.WriteLine("La misión ya está Finalizada.");
                                }
                            }
                        }

                        if (encontrada == false)
                        {
                            Console.WriteLine("No se encontró una misión con ese ID.");
                        }

                        break;

                    case 4:
                        bool hayEnCurso = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (misiones[i, 4] == "1")
                            {
                                hayEnCurso = true;

                                Console.WriteLine("Misión: " + misiones[i, 0]);
                                Console.WriteLine("Mapa: " + misiones[i, 1]);
                                Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);
                                Console.WriteLine("Estado: En Curso");
                                Console.WriteLine("-------------------------");
                            }
                        }

                        if (hayEnCurso == false)
                        {
                            Console.WriteLine("No hay misiones en curso.");
                        }

                        break;

                    case 5:
                        if (cantidad == 0)
                        {
                            Console.WriteLine("No hay misiones registradas.");
                        }
                        else
                        {
                            int mayor = int.Parse(misiones[0, 2]);

                            for (int i = 1; i < cantidad; i++)
                            {
                                if (int.Parse(misiones[i, 2]) > mayor)
                                {
                                    mayor = int.Parse(misiones[i, 2]);
                                }
                            }

                            Console.WriteLine("Misión(es) con más objetos a extraer:");

                            for (int i = 0; i < cantidad; i++)
                            {
                                if (int.Parse(misiones[i, 2]) == mayor)
                                {
                                    Console.WriteLine("Misión: " + misiones[i, 0]);
                                    Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                    Console.WriteLine("-------------------------");
                                }
                            }
                        }

                        break;

                    case 6:
                        for (int mapa = 1; mapa <= 3; mapa++)
                        {
                            int suma = 0;
                            int cantidadMapa = 0;

                            for (int i = 0; i < cantidad; i++)
                            {
                                if (int.Parse(misiones[i, 1]) == mapa)
                                {
                                    suma = suma + int.Parse(misiones[i, 3]);
                                    cantidadMapa++;
                                }
                            }

                            if (mapa == 1)
                            {
                                Console.Write("Hagwarts: ");
                            }
                            else if (mapa == 2)
                            {
                                Console.Write("La Casa del Viejo: ");
                            }
                            else
                            {
                                Console.Write("El Laboratorio: ");
                            }

                            if (cantidadMapa > 0)
                            {
                                double promedio = (double)suma / cantidadMapa;
                                Console.WriteLine(promedio);
                            }
                            else
                            {
                                Console.WriteLine("No hay misiones.");
                            }
                        }

                        break;

                    case 7:
                        bool mapaFiltroValido = false;
                        int mapaFiltro = 0;

                        while (mapaFiltroValido == false)
                        {
                            Console.Write("Ingrese el mapa (1-Hagwarts, 2-La Casa del Viejo, 3-El Laboratorio): ");
                            mapaFiltro = int.Parse(Console.ReadLine());

                            if (mapaFiltro >= 1 && mapaFiltro <= 3)
                            {
                                mapaFiltroValido = true;
                            }
                            else
                            {
                                Console.WriteLine("Ese mapa no es de este juegazo.");
                            }
                        }

                        bool hayMisiones = false;

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (int.Parse(misiones[i, 1]) == mapaFiltro)
                            {
                                hayMisiones = true;

                                Console.WriteLine("Misión: " + misiones[i, 0]);
                                Console.WriteLine("Mapa: " + misiones[i, 1]);
                                Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);
                                Console.WriteLine("Estado: " + misiones[i, 4]);
                                Console.WriteLine("-------------------------");
                            }
                        }

                        if (hayMisiones == false)
                        {
                            Console.WriteLine("No hay misiones en ese mapa.");
                        }

                        break;

                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 8);


        }
    }
}
