using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ElEterNota
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad_de_refugio = 0;
            int[,] matriz = new int[20,5];
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
                        int j = 0;
                        int i = 0;
                        if (cantidad_de_refugio > 20)
                        {
                            Console.WriteLine("El refugio esta lleno");
                        }
                        else
                        { 
                            Console.WriteLine("Vas a añadir un refugio");
                            Console.WriteLine("");
                            Console.Write("Dime un codigo para el refugio: ");
                            int codigo = int.Parse(Console.ReadLine());
                            matriz[j, i] = codigo;
                            i++;
                            Console.Clear();
                            Console.WriteLine("Capacidad maxima: 20 ");
                            Console.Write("Dime la capacidad maxima del refugio: ");
                            int capacidad_maxima = int.Parse(Console.ReadLine());
                            matriz[j, i] = capacidad_maxima;
                            while(capacidad_maxima>20)
                            {
                                Console.WriteLine("Ingrese de nuevo la capacidad maxima");
                                Console.Write("Dime la capacidad maxima del refugio: ");
                                capacidad_maxima = int.Parse(Console.ReadLine());
                                matriz[j, i] = capacidad_maxima;
                            }
                            i++;
                            Console.Clear();
                            Console.Write("Dime los suministros disponibles del refugio");
                            int suministros = int.Parse(Console.ReadLine());
                            matriz[j, i] = suministros;
                            while(suministros<0)
                            {

                            }
                            i++;
                            Console.WriteLine("");
                            Console.WriteLine("En que zona esta ubicada el refugio?");
                            Console.WriteLine("1. Norte(Congreso)");
                            Console.WriteLine("2. Sur(Constitucion)");
                            Console.WriteLine("3. Oeste(Flores)");
                            Console.WriteLine("4. Centro(Microcentro)");
                            Console.WriteLine("");
                            Console.Write("Respuesta: ");
                            int zona = int.Parse(Console.ReadLine());
                            matriz[j, i] = zona;
                            i++;
                            Console.Write("Tiene personas alojadas el refugio?(Si=1 y No=0):");
                            int ocupacion = int.Parse(Console.ReadLine());
                            matriz[j, i] = ocupacion;
                            i++;
                            j++;
                        }
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        // Lógica para ocupar refugio
                        break;
                    case 4:
                        // Lógica para mostrar ocupados
                        break;
                    case 5:
                        // Lógica para refugio con más suministros
                        break;
                    case 6:
                        // Lógica para promedio por zona
                        break;
                    case 7:
                        // Lógica para filtrar por zona
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
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
