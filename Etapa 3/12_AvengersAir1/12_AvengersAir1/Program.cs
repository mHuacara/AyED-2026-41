using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int asientos_disponibles = 80;
            int asientos_ocupados = 0;
            int asientoModificado = 0;
            int asiento = 0;
            int asientoDevolver = 0;
            int ventasPrimeraClase = 0;
            int ventasEmergencia = 0;
            int ventasEconomicas = 0;
            int recaudacion = 0;

            string[,] pasajeros = new string[80, 7];
            while (opcion != 7)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Menu Principal - AvengersAir Vuelo Buenos Aires a Wakanda");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Asientos Disponibles: " + asientos_disponibles);
                Console.WriteLine("Asientos Ocupados: " + asientos_ocupados);
                Console.WriteLine("1. Vender asientos");
                Console.WriteLine("2. Devolver asiento");
                Console.WriteLine("3. Modificar asiento");
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine("5. Buscar pasajeros por edad");
                Console.WriteLine("6. Obtener asientos con DNI par");
                Console.WriteLine("7.Salir");
                Console.WriteLine("------------------------------");

                Console.Write("Ingrese la opcion deseada: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Console.Clear();


                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("VENDER ASIENTO");
                        Console.WriteLine("----------------------------------------");

                        Console.WriteLine("Asientos disponibles:");

                        for (int i = 0; i < 80; i++)
                        {
                            if (pasajeros[i, 6] == null)
                            {
                                if (i + 1 <= 20)
                                {
                                    Console.WriteLine("Asiento " + (i + 1) + " - Primera clase");
                                }
                                else if (i + 1 >= 40 && i + 1 <= 43)
                                {
                                    Console.WriteLine("Asiento " + (i + 1) + " - Salida de emergencia");
                                }
                                else
                                {
                                    Console.WriteLine("Asiento " + (i + 1) + " - Económica");
                                }
                            }
                        }

                        Console.WriteLine();

                        Console.Write("Ingrese el numero de asiento: ");
                        asiento = int.Parse(Console.ReadLine());

                        if (asiento < 1 || asiento > 80)
                        {
                            Console.WriteLine("Numero de asiento invalido.");
                        }
                        else if (pasajeros[asiento - 1, 6] != null)
                        {
                            Console.WriteLine("El asiento ya esta ocupado.");
                        }
                        else
                        {
                            pasajeros[asiento - 1, 0] = asiento.ToString();

                            Console.Write("Ingrese el nombre: ");
                            pasajeros[asiento - 1, 1] = Console.ReadLine();

                            Console.Write("Ingrese el apellido: ");
                            pasajeros[asiento - 1, 2] = Console.ReadLine();

                            Console.Write("Ingrese la edad: ");
                            pasajeros[asiento - 1, 3] = Console.ReadLine();

                            Console.Write("Ingrese el DNI: ");
                            pasajeros[asiento - 1, 4] = Console.ReadLine();

                            Console.Write("Ingrese la nacionalidad: ");
                            pasajeros[asiento - 1, 5] = Console.ReadLine();

                            Console.Write("Ingrese el estado de ocupacion: ");
                            pasajeros[asiento - 1, 6] = Console.ReadLine();

                            asientos_disponibles--;
                            asientos_ocupados++;

                            Console.WriteLine();
                            Console.WriteLine("Asiento vendido correctamente.");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("DEVOLVER ASIENTO");
                        Console.WriteLine("----------------------------------------");

                        Console.Write("Ingrese el numero de asiento: ");
                        asientoDevolver = int.Parse(Console.ReadLine());

                        if (asientoDevolver < 1 || asientoDevolver > 80)
                        {
                            Console.WriteLine("Numero de asiento invalido.");
                        }
                        if (pasajeros[asientoDevolver - 1, 6] == null)
                        {
                            Console.WriteLine("El asiento esta libre.");
                        }
                        else
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                pasajeros[asientoDevolver - 1, i] = null;
                            }

                            asientos_disponibles++;
                            asientos_ocupados--;

                            Console.WriteLine("Asiento devuelto correctamente.");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Que asiento desea modificar?: ");
                        asientoModificado = int.Parse(Console.ReadLine());
                        if (pasajeros[asientoModificado - 1,0] !=null)
                        {
                            Console.WriteLine("Podra actualiza su informacion ");
                            Console.Write("");
                            Console.Write("Ingrese el nombre: ");
                            pasajeros[asientoModificado - 1, 1] = Console.ReadLine();

                            Console.Write("Ingrese el apellido: ");
                            pasajeros[asientoModificado - 1, 2] = Console.ReadLine();

                            Console.Write("Ingrese la edad: ");
                            pasajeros[asientoModificado- 1, 3] = Console.ReadLine();

                            Console.Write("Ingrese el DNI: ");
                            pasajeros[asientoModificado - 1, 4] = Console.ReadLine();

                            Console.Write("Ingrese la nacionalidad: ");
                            pasajeros[asientoModificado - 1, 5] = Console.ReadLine();

                            Console.Write("Ingrese el estado de ocupacion: ");
                            pasajeros[asientoModificado - 1, 6] = Console.ReadLine();
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        if (asiento >= 1 && asiento <= 20) 
                        {
                            ventasPrimeraClase += 200;
                        }
                        if(asiento>= 40 && asiento <=43 )
                        {
                            ventasEmergencia += 100;
                        }
                        if(asiento>=43 )
                        {
                            ventasEconomicas += 80;
                        }
                        recaudacion = ventasEconomicas + ventasEmergencia + ventasPrimeraClase;
                        Console.WriteLine("Dinero recaudado por la venta : ");

                        Console.ReadKey();
                        break;
                    case 5:
                        //Para comprobar
                        Console.WriteLine(pasajeros[asientoModificado - 1, 1]);
                        Console.WriteLine(pasajeros[asientoModificado - 1, 2]);
                        Console.WriteLine(pasajeros[asientoModificado - 1, 3]);
                        Console.WriteLine(pasajeros[asientoModificado - 1, 4]);
                        Console.WriteLine(pasajeros[asientoModificado - 1, 5]);
                        Console.WriteLine(pasajeros[asientoModificado - 1, 6]);
                        Console.ReadKey();
                        break;

                }
                
        

                

            }
        }
    }
}
