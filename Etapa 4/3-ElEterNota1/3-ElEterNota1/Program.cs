using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ElEterNota1
{
    class Program
    {
        static int[,] matriz = new int[20, 5];
        static int refugios_registrados = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");

                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        registrarRefugios();
                        break;

                    case 2:
                        mostrarRefugios();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 8);
        }
        static void registrarRefugios()
        {
            if (refugios_registrados >= 20)
            {
                Console.WriteLine("No hay refugios... ¡Vamos a morir!");
                return;
            }

            Console.WriteLine("Vas a añadir un refugio");
            Console.WriteLine();

            Console.Write("Dime un código para el refugio: ");
            int codigo = int.Parse(Console.ReadLine());

            matriz[refugios_registrados, 0] = codigo;

            int capacidad_maxima;

            do
            {
                Console.Write("Dime la capacidad máxima del refugio: ");
                capacidad_maxima = int.Parse(Console.ReadLine());

                if (capacidad_maxima <= 0)
                {
                    Console.WriteLine("La capacidad debe ser mayor a 0.");
                }

            } while (capacidad_maxima <= 0);

            matriz[refugios_registrados, 1] = capacidad_maxima;

            int suministros;

            do
            {
                Console.Write("Dime los suministros disponibles: ");
                suministros = int.Parse(Console.ReadLine());

                if (suministros <= 0)
                {
                    Console.WriteLine("Los suministros deben ser mayores a 0.");
                }

            } while (suministros <= 0);

            matriz[refugios_registrados, 2] = suministros;

            int zona;

            do
            {
                Console.WriteLine();
                Console.WriteLine("¿En qué zona está ubicado el refugio?");
                Console.WriteLine("1. Norte (Congreso)");
                Console.WriteLine("2. Sur (Constitución)");
                Console.WriteLine("3. Oeste (Flores)");
                Console.WriteLine("4. Centro (Microcentro)");
                Console.Write("Respuesta: ");

                zona = int.Parse(Console.ReadLine());

                if (zona < 1 || zona > 4)
                {
                    Console.WriteLine("Zona inválida.");
                }

            } while (zona < 1 || zona > 4);

            matriz[refugios_registrados, 3] = zona;

            int ocupacion;

            do
            {
                Console.Write("¿Tiene personas alojadas? (Si = 1 / No = 0): ");
                ocupacion = int.Parse(Console.ReadLine());

                if (ocupacion != 0 && ocupacion != 1)
                {
                    Console.WriteLine("Debe ingresar 1 o 0.");
                }

            } while (ocupacion != 0 && ocupacion != 1);

            matriz[refugios_registrados, 4] = ocupacion;

            refugios_registrados++;

            Console.WriteLine();
            Console.WriteLine("Refugio registrado correctamente.");
        }
        static void mostrarRefugios()
        {
            if (refugios_registrados == 0)
            {
                Console.WriteLine("No hay refugios registrados.");
            }
            else
            {
                for (int j = 0; j < refugios_registrados; j++)
                {
                    Console.WriteLine();

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(matriz[j, i] + "\t");
                    }

                    Console.WriteLine();
                }
            }
        }
        static void ocuparRefugio()
        {
            Console.WriteLine("Que refugio quieres ocupar?: ");
            Console.WriteLine("");
            for (int i = 0; i < refugios_registrados; i++) 
            {
                if (matriz[i, 0] == 0)
                {
                    Console.WriteLine("Refugio " + i +": "+ matriz[i, 0]);
                }
            }
            int refugio_seleccionado = int.Parse(Console.ReadLine());
            while (matriz[refugio_seleccionado, 0] != 0)
            {
                Console.WriteLine("No somos Okupas, esto ya està ocupado");
                Console.WriteLine(" ");
                Console.Write("Que refugio quieres ocupar?: ");
                refugio_seleccionado = int.Parse(Console.ReadLine());
            }
        }
    }

}


