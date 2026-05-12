using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int costo = 2500;
            int racaudaciontotal = 0;
            int contador = 0;
            do
            {
                Console.WriteLine("----MENU----");
                Console.WriteLine("1 = ingresar vehiculo");
                Console.WriteLine("2 = Retirar vehiulo");
                Console.WriteLine("3 = Consultar estado");
                Console.WriteLine("4 = Cerrar caja y Salir");
                int Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        if (contador >= 20)
                        {
                            Console.WriteLine("Estacionamiento lleno");
                        }
                        else
                        {
                            Console.WriteLine("vehiculo ingresado");
                            contador++;
                            Console.WriteLine(contador + "/20");
                        }
                        break;
                    case 2:
                        if (contador == 0)
                        {
                            Console.WriteLine("Error:el estacionamiento esta vacio");
                        }
                        else
                        { 
                        Console.WriteLine("ingrese el monto pago: ");
                        int pago = int.Parse(Console.ReadLine());
                        if (pago >= costo)
                        {
                            int vuelto = pago - costo;
                            Console.WriteLine("salida registrada.su vuelto es:$" + vuelto);
                            contador--;
                            racaudaciontotal += pago;
                        }
                        else
                        {
                            Console.WriteLine("pago insuficiente");
                        }
                       }
                        break;
                    case 3:
                        Console.WriteLine("----Estado Actual----");
                        Console.WriteLine("vehiculos presentes:" + contador + "/20");
                        Console.WriteLine("Diner0 en caja:" + racaudaciontotal);
                        break;
                    case 4:
                        int correcto = 1234;
                        Console.WriteLine("ingrese la clave para salir");
                        int clave = int.Parse(Console.ReadLine());
                        if (clave == correcto)
                        {
                            Console.WriteLine("Caja cerrada.Total del dia:$" + racaudaciontotal);

                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("acceso denegado");
                        }
                        break;
                    default:
                        Console.WriteLine("comando desconocido");
                        break;
                }
            } while (opcion != 4);

            Console.ReadKey();
        }
    }
}
