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
            int[,] tabla = new int [80, 8];
            int[] asientos = new int[80];
            string[] nombres = new string[80];
            string[] apellidos = new string[80];
            int[] edades = new int[80];
            string[] nacionalidades = new string[80];
            bool[] estado_de_ocupacion = new bool[80];
            int asientos_disponibles = 80;
            int asientos_ocupados = 0;
            int opcion = 0;
            int eleccion;
            while(opcion != 7)
            { 
            Console.WriteLine("Bienvenido a AvengersAir!");
            Console.WriteLine(" ");
            Console.WriteLine("Asientos disponibles: " + asientos_disponibles);
            Console.WriteLine("Asientos vendidos: " + asientos_ocupados);
            Console.WriteLine(" ");
            Console.WriteLine("1. Vender asiento ");
            Console.WriteLine("2. Devolver asiento ");
            Console.WriteLine("3. Modificar asiento ");
            Console.WriteLine("4. Calcular ventas ");
            Console.WriteLine("5. Buscar pasajeros por edad ");
            Console.WriteLine("6. asientos con DNI par ");
            Console.WriteLine("7. Salir");
            Console.WriteLine("");
            Console.Write(" Que opcion quieres elegir?: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        int contador = 1;
                        
                        for (int i = 0; i < 80; i++) 
                        {
                            asientos[i] = contador;
                            estado_de_ocupacion[i] = false;
                            contador++;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("");
                        Console.Write("Asientos de primera clase: ");
                        for (int i = 0; i < 80; i++) 
                        {
                            if (asientos[i] <= 20)
                            {
                                Console.Write(asientos[i]+" ");
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.Write("Asiento de salidas de emergencia: ");
                        for (int i = 0; i < 80; i++) 
                        {
                            if(asientos[i]==40 || asientos[i]==41 || asientos[i]==42 || asientos[i]==43)
                            {
                                Console.Write(asientos[i] + " ");
                            }
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("");
                        Console.Write("Asientos de clase economica regular: ");
                        for (int i = 0; i < 80; i++)
                        {
                            if(asientos[i]>20 || asientos[i]>=40 && asientos[i]<=43)
                            {
                                Console.Write(asientos[i] + " ");
                            }
                        }
                        Console.Write("Que asiento deseas tener?: ");
                        int posicion = int.Parse(Console.ReadLine());
                        posicion -= 1;
                        while(estado_de_ocupacion[posicion]==true)
                        {
                            Console.WriteLine("El asiento esta ocupado, debes seleccionar otro");
                            Console.Write("Que asiento deseas tener?: ");
                            posicion = int.Parse(Console.ReadLine());
                        }
                        estado_de_ocupacion[posicion] = true;
                        Console.Clear();
                        Console.Write("Ingrese su nombre: ");
                        string nombre = Console.ReadLine();
                        nombres[posicion]= nombre;
                        Console.Write("Ingrese su apellido: ");
                        string apellido = Console.ReadLine();
                        apellidos[posicion] = apellido;


                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
