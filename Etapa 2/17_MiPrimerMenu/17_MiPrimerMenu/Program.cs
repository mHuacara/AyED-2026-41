using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int num1;
            int num2;
            int resultado;
            string respuesta;
            string afirmacion = "Si";
            string negacion = "No";
                Console.WriteLine("¡Bienvenido al programa!");
                Console.WriteLine("Le daremo opciones para que pueda elegir tranquilamente:");
                Console.WriteLine(" ");
                Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine("");
                Console.WriteLine("1.Escribirte un mensaje");
                Console.WriteLine("2.Te pediremos dos numero enteros");
                Console.WriteLine("3.Te hare una pregunta");
                Console.WriteLine("4.SALIR");
                Console.WriteLine(" ");
                Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine(" ");
                Console.WriteLine("Que opcion seleccionara?: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Hola chavalin");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Escribe un numero entero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe otro numero: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("La suma de tus numeros es de " + resultado);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Responde con un SI o un NO");
                        Console.WriteLine("Sabes a que te estas dedicando verdad?: ");
                        respuesta = Console.ReadLine();
                        if (afirmacion.ToLower() == respuesta.ToLower())
                        {
                            Console.Write("Felicidades sabes que sos un progrmador y no saldras de casa");
                        }
                        else if (negacion.ToLower() == respuesta.ToLower())
                        {
                            Console.Write("Aun tienes tiempo para salir de ahi");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Salio del programa");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida,reinicie el programa,presione cualquier tecla");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
        }
    }
}
