using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] asientos = new string[80, 8];

            int opcion = 0;
            int asientos_disponibles = 80;
            int asientos_ocupados = 0;

            for (int i = 0; i < 80; i++)
            {
                asientos[i, 0] = (i + 1).ToString();

                if (i < 20)
                {
                    asientos[i, 1] = "Primera Clase";
                }
                else if (i >= 39 && i <= 42)
                {
                    asientos[i, 1] = "Salida de Emergencia";
                }
                else
                {
                    asientos[i, 1] = "Economica";
                }

                asientos[i, 2] = "";
                asientos[i, 3] = "";
                asientos[i, 4] = "";
                asientos[i, 5] = "";
                asientos[i, 6] = "";
                asientos[i, 7] = "false";
            }

            while (opcion != 7)
            {
                Console.Clear();

                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Menu Principal - AvengersAir Vuelo Buenos Aires a Wakanda");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Asientos Disponibles: " + asientos_disponibles);
                Console.WriteLine("Asientos Ocupados: " + asientos_ocupados);
                Console.WriteLine("1. Vender Asiento");
                Console.WriteLine("2. Devolver Asiento");
                Console.WriteLine("3. Modificar Asiento");
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine("5. Buscar Pasajeros por Edad");
                Console.WriteLine("6. Obtener Asientos con DNI Par");
                Console.WriteLine("7. Salir");
                Console.Write("Ingrese la opcion deseada: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Asientos disponibles:");

                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 2] == "")
                            {
                                Console.WriteLine( "Asiento " + asientos[i, 0] + " - " + asientos[i, 1]);
                            }
                        }

                        Console.Write("Ingrese el numero de asiento: ");
                        int numero = int.Parse(Console.ReadLine());

                        int posicion = numero - 1;

                        if (posicion >= 0 && posicion < 80)
                        {
                            if (asientos[posicion, 2] == "")
                            {
                                Console.Write("Ingrese nombre: ");
                                asientos[posicion, 2] = Console.ReadLine();

                                Console.Write("Ingrese apellido: ");
                                asientos[posicion, 3] = Console.ReadLine();

                                Console.Write("Ingrese edad: ");
                                asientos[posicion, 4] = Console.ReadLine();

                                Console.Write("Ingrese DNI: ");
                                asientos[posicion, 5] = Console.ReadLine();

                                Console.Write("Ingrese nacionalidad: ");
                                asientos[posicion, 6] = Console.ReadLine();

                                int estado = -1;

                                while (estado != 1 && estado != 0)
                                {
                                    Console.Write("Ingrese el estado de ocupacion (1 = Ocupado / 0 = Libre): ");
                                    estado = int.Parse(Console.ReadLine());

                                    if (estado == 1)
                                    {
                                        asientos[posicion, 7] = "true";
                                        asientos_ocupados++;
                                    }
                                    else if (estado == 0)
                                    {
                                        asientos[posicion, 7] = "false";
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opcion incorrecta. Ingrese 1 o 0.");
                                    }
                                }

                                asientos_disponibles--;

                                Console.WriteLine("Asiento vendido correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("El asiento ya esta vendido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Numero de asiento incorrecto.");
                        }

                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Ingrese el numero de asiento a devolver: ");
                        numero = int.Parse(Console.ReadLine());

                        posicion = numero - 1;

                        if (posicion >= 0 && posicion < 80)
                        {
                            if (asientos[posicion, 2] != "")
                            {
                                if (asientos[posicion, 7] == "true")
                                {
                                    asientos_ocupados--;
                                }

                                asientos[posicion, 2] = "";
                                asientos[posicion, 3] = "";
                                asientos[posicion, 4] = "";
                                asientos[posicion, 5] = "";
                                asientos[posicion, 6] = "";
                                asientos[posicion, 7] = "false";

                                asientos_disponibles++;

                                Console.WriteLine("Asiento devuelto correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("El asiento esta libre.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Numero de asiento incorrecto.");
                        }

                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Asientos vendidos:");

                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 2] != "")
                            {
                                string estado;

                                if (asientos[i, 7] == "true")
                                {
                                    estado = "Ocupado";
                                }
                                else
                                {
                                    estado = "Libre";
                                }

                                Console.WriteLine("Asiento " + asientos[i, 0] + " - " + asientos[i, 2] + " " +asientos[i, 3] + " - Edad: " + asientos[i, 4] + " - DNI: " + asientos[i, 5] + " - Nacionalidad: " + asientos[i, 6] + " - Estado: " + estado);
                            }
                        }
                        Console.Write("Ingrese el número de asiento que desea modificar: ");
                        int asientoModificar = int.Parse(Console.ReadLine());

                        if (asientoModificar >= 1 && asientoModificar <= 80)
                        {
                            int fila = asientoModificar - 1;

                            Console.WriteLine();
                            Console.WriteLine("| N° Asiento | Tipo de Asiento | Nombre | Apellido | Edad |      DNI      | Nacionalidad | Ocupado |");

                            Console.WriteLine("      " + asientos[fila, 0] + "         " + asientos[fila, 1] + "    " + asientos[fila, 2] + "        " + asientos[fila, 3] + "          " + asientos[fila, 4] + "        " + asientos[fila, 5] + "             " + asientos[fila, 6] + "              " + asientos[fila, 7]);
                            Console.WriteLine();
                            Console.Write("Ingrese el nuevo nombre: ");
                            asientos[fila, 2] = Console.ReadLine();

                            Console.Write("Ingrese el nuevo apellido: ");
                            asientos[fila, 3] = Console.ReadLine();

                            Console.Write("Ingrese la nueva edad: ");
                            asientos[fila, 4] = Console.ReadLine();

                            Console.Write("Ingrese el nuevo DNI: ");
                            asientos[fila, 5] = Console.ReadLine();

                            Console.Write("Ingrese la nueva nacionalidad: ");
                            asientos[fila, 6] = Console.ReadLine();

                            Console.WriteLine("Asiento modificado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Número de asiento no válido.");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        int total = 0;
                        int total_primera = 0;
                        int total_emergencia = 0;
                        int total_economica = 0;

                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 2] != "")
                            {
                                if (i < 20)
                                {
                                    total = total + 200;
                                    total_primera = total_primera + 200;
                                }
                                else if (i >= 39 && i <= 42)
                                {
                                    total = total + 80;
                                    total_emergencia = total_emergencia + 80;
                                }
                                else
                                {
                                    total = total + 100;
                                    total_economica = total_economica + 100;
                                }
                            }
                        }

                        Console.WriteLine("Recaudacion por clase:");
                        Console.WriteLine("Primera Clase: $" + total_primera);
                        Console.WriteLine("Salidas de Emergencia: $" + total_emergencia);
                        Console.WriteLine("Economica: $" + total_economica);
                        Console.WriteLine("------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Total de ventas: $" + total);

                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Write("Ingrese la edad a buscar: ");
                        int edad = int.Parse(Console.ReadLine());

                        bool encontrado = false;

                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 2] != "")
                            {
                                int edadPasajero = int.Parse(asientos[i, 4]);

                                if (edadPasajero == edad)
                                {
                                    Console.WriteLine( "Asiento: " + asientos[i, 0] + " - " + asientos[i, 2] +  " " + asientos[i, 3]);

                                    encontrado = true;
                                }
                            }
                        }

                        if (encontrado == false)
                        {
                            Console.WriteLine("No se encontraron pasajeros con esa edad.");
                        }

                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case 6:
                        encontrado = false;

                        Console.WriteLine("Asientos con DNI par:");

                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 2] != "")
                            {
                                int dni = int.Parse(asientos[i, 5]);

                                if (dni % 2 == 0)
                                {
                                    Console.WriteLine("Asiento: " + asientos[i, 0]);
                                    encontrado = true;
                                }
                            }
                        }

                        if (encontrado == false)
                        {
                            Console.WriteLine("No hay pasajeros con DNI par.");
                        }

                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
