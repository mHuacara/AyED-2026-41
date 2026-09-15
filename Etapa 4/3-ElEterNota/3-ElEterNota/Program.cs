using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ElEterNota
{
    class Program
    {
        static int[,] refugios = new int[20, 5];
        static int cantidad = 0;

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
                Console.WriteLine("6. Promedio de capacidad por zona");
                Console.WriteLine("7. Filtrar refugios por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarRefugio();
                        break;

                    case 2:
                        MostrarRefugios();
                        break;

                    case 3:
                        OcuparRefugio();
                        break;

                    case 4:
                        MostrarOcupados();
                        break;

                    case 5:
                        RefugioMasSuministros();
                        break;

                    case 6:
                        PromedioPorZona();
                        break;

                    case 7:
                        FiltrarPorZona();
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

        static void AgregarRefugio()
        {
            if (cantidad >= 20)
            {
                Console.WriteLine("No hay refugios... ¡Vamos a morir!");
            }
            else
            {
                bool codigoValido = false;

                while (codigoValido == false)
                {
                    Console.Write("Código del refugio: ");
                    int codigo = int.Parse(Console.ReadLine());

                    bool encontrado = false;

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (refugios[i, 0] == codigo)
                        {
                            encontrado = true;
                        }
                    }

                    if (encontrado == false)
                    {
                        refugios[cantidad, 0] = codigo;
                        codigoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("El código ya está registrado.");
                    }
                }

                bool capacidadValida = false;

                while (capacidadValida == false)
                {
                    Console.Write("Capacidad máxima: ");
                    int capacidad = int.Parse(Console.ReadLine());

                    if (capacidad > 0)
                    {
                        refugios[cantidad, 1] = capacidad;
                        capacidadValida = true;
                    }
                    else
                    {
                        Console.WriteLine("No se puede sobrevivir debiendo...");
                    }
                }

                bool suministrosValidos = false;

                while (suministrosValidos == false)
                {
                    Console.Write("Suministros disponibles: ");
                    int suministros = int.Parse(Console.ReadLine());

                    if (suministros > 0)
                    {
                        refugios[cantidad, 2] = suministros;
                        suministrosValidos = true;
                    }
                    else
                    {
                        Console.WriteLine("No se puede sobrevivir debiendo...");
                    }
                }

                bool zonaValida = false;

                while (zonaValida == false)
                {
                    Console.WriteLine("1. NORTE (Congreso)");
                    Console.WriteLine("2. SUR (Constitución)");
                    Console.WriteLine("3. OESTE (Flores)");
                    Console.WriteLine("4. CENTRO (Microcentro)");
                    Console.Write("Zona: ");

                    int zona = int.Parse(Console.ReadLine());

                    if (zona >= 1 && zona <= 4)
                    {
                        refugios[cantidad, 3] = zona;
                        zonaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Zona inválida, esa parte ya está perdida");
                    }
                }

                bool ocupadoValido = false;

                while (ocupadoValido == false)
                {
                    Console.Write("¿Hay personas alojadas? (1 = Sí / 0 = No): ");
                    int ocupado = int.Parse(Console.ReadLine());

                    if (ocupado == 0 || ocupado == 1)
                    {
                        refugios[cantidad, 4] = ocupado;
                        ocupadoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese 1 para Sí o 0 para No.");
                    }
                }

                cantidad++;

                Console.WriteLine("Refugio agregado correctamente.");
            }
        }

        static void MostrarRefugios()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay refugios registrados.");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Refugio " + (i + 1) + ":");
                    Console.WriteLine("Código: " + refugios[i, 0]);
                    Console.WriteLine("Capacidad máxima: " + refugios[i, 1]);
                    Console.WriteLine("Suministros: " + refugios[i, 2]);

                    if (refugios[i, 3] == 1)
                    {
                        Console.WriteLine("Zona: NORTE (Congreso)");
                    }
                    else if (refugios[i, 3] == 2)
                    {
                        Console.WriteLine("Zona: SUR (Constitución)");
                    }
                    else if (refugios[i, 3] == 3)
                    {
                        Console.WriteLine("Zona: OESTE (Flores)");
                    }
                    else
                    {
                        Console.WriteLine("Zona: CENTRO (Microcentro)");
                    }

                    if (refugios[i, 4] == 1)
                    {
                        Console.WriteLine("Ocupado: Si");
                    }
                    else
                    {
                        Console.WriteLine("Ocupado: No");
                    }

                    Console.WriteLine("-------------------------");
                }
            }
        }

        static void OcuparRefugio()
        {
            bool hayLibres = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (refugios[i, 4] == 0)
                {
                    hayLibres = true;
                }
            }

            if (hayLibres == false)
            {
                Console.WriteLine("No hay refugios disponibles.");
            }
            else
            {
                Console.WriteLine("Refugios no ocupados:");

                for (int i = 0; i < cantidad; i++)
                {
                    if (refugios[i, 4] == 0)
                    {
                        Console.WriteLine("Refugio " + (i + 1) + ":");
                        Console.WriteLine("Código: " + refugios[i, 0]);
                        Console.WriteLine("Capacidad máxima: " + refugios[i, 1]);
                        Console.WriteLine("Suministros: " + refugios[i, 2]);
                        Console.WriteLine("-------------------------");
                    }
                }

                Console.Write("Ingrese el código del refugio que desea ocupar: ");
                int codigo = int.Parse(Console.ReadLine());

                bool encontrado = false;

                for (int i = 0; i < cantidad; i++)
                {
                    if (refugios[i, 0] == codigo)
                    {
                        encontrado = true;

                        if (refugios[i, 4] == 0)
                        {
                            refugios[i, 4] = 1;
                            Console.WriteLine("Refugio ocupado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No somos Okupas, esto ya está ocupado");
                        }
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("El código no existe.");
                }
            }
        }

        static void MostrarOcupados()
        {
            bool hayOcupados = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (refugios[i, 4] == 1)
                {
                    hayOcupados = true;

                    Console.WriteLine("Refugio " + (i + 1) + ":");
                    Console.WriteLine("Código: " + refugios[i, 0]);
                    Console.WriteLine("Capacidad máxima: " + refugios[i, 1]);
                    Console.WriteLine("Suministros: " + refugios[i, 2]);
                    Console.WriteLine("-------------------------");
                }
            }

            if (hayOcupados == false)
            {
                Console.WriteLine("No hay refugios ocupados.");
            }
        }

        static void RefugioMasSuministros()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("No hay refugios registrados.");
            }
            else
            {
                int mayor = refugios[0, 2];

                for (int i = 1; i < cantidad; i++)
                {
                    if (refugios[i, 2] > mayor)
                    {
                        mayor = refugios[i, 2];
                    }
                }

                Console.WriteLine("Refugio(s) con más suministros:");

                int cantidadMayor = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    if (refugios[i, 2] == mayor)
                    {
                        Console.WriteLine("Refugio " + (i + 1) + ":");
                        Console.WriteLine("Código: " + refugios[i, 0]);
                        Console.WriteLine("Suministros: " + refugios[i, 2]);
                        Console.WriteLine("-------------------------");

                        cantidadMayor++;
                    }
                }

                if (cantidadMayor > 1)
                {
                    Console.WriteLine("Hay varios refugios con la misma cantidad máxima de suministros.");
                }
            }
        }

        static void PromedioPorZona()
        {
            for (int zona = 1; zona <= 4; zona++)
            {
                int suma = 0;
                int cantidadZona = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    if (refugios[i, 3] == zona)
                    {
                        suma = suma + refugios[i, 1];
                        cantidadZona++;
                    }
                }

                if (zona == 1)
                {
                    Console.Write("NORTE: ");
                }
                else if (zona == 2)
                {
                    Console.Write("SUR: ");
                }
                else if (zona == 3)
                {
                    Console.Write("OESTE: ");
                }
                else
                {
                    Console.Write("CENTRO: ");
                }

                if (cantidadZona > 0)
                {
                    double promedio = (double)suma / cantidadZona;
                    Console.WriteLine(promedio);
                }
                else
                {
                    Console.WriteLine("No hay refugios.");
                }
            }
        }

        static void FiltrarPorZona()
        {
            bool zonaValida = false;
            int zona = 0;

            while (zonaValida == false)
            {
                Console.Write("Ingrese la zona (1-4): ");
                zona = int.Parse(Console.ReadLine());

                if (zona >= 1 && zona <= 4)
                {
                    zonaValida = true;
                }
                else
                {
                    Console.WriteLine("Zona inválida, esa parte ya está perdida");
                }
            }

            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (refugios[i, 3] == zona)
                {
                    encontrado = true;

                    Console.WriteLine("Refugio " + (i + 1) + ":");
                    Console.WriteLine("Código: " + refugios[i, 0]);
                    Console.WriteLine("Capacidad máxima: " + refugios[i, 1]);
                    Console.WriteLine("Suministros: " + refugios[i, 2]);

                    if (refugios[i, 4] == 1)
                    {
                        Console.WriteLine("Ocupado: Si");
                    }
                    else
                    {
                        Console.WriteLine("Ocupado: No");
                    }

                    Console.WriteLine("-------------------------");
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("No hay refugios en esa zona.");
            }
        }
    }
}

