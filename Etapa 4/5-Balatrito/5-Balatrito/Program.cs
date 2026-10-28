using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Balatrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MINI BALATRO ===");
            Console.WriteLine();
            // Generar una mano aleatoria de 5 cartas
            string[] mano = generarManoAleatoria();
            // Analizar que tipo de mano se obtuvo
            string tipo = tipoDeMano(mano);
            // Calcular el valor de las cartas
            int basePts = puntajeBase(mano);
            // Obtener el multiplicador de la jugada
            double mult = multiplicador(tipo);
            // Calcular puntaje antes de Jokers
            double total = basePts * mult;
            // Jokers disponibles
            bool jokerX2 = true;
            bool jokerMas10 = true;
            // Aplicar los efectos de los Jokers
            total = aplicarJokers(total, jokerX2, jokerMas10);
            // Mostrar el resultado
            mostrarResumen(mano, tipo, basePts, mult, total);
        }
        static string[] generarManoAleatoria()
        {
            Random rand = new Random();
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };
            string[] mano = new string[5];
            for (int i = 0; i < 5; i++)
            {
                int r = rand.Next(0, 13);
                int p = rand.Next(0, 4);
                mano[i] = rangos[r] + palos[p];
            }
            return mano;
        }

        static string tipoDeMano(string[]mano)
        {
            int[] cantidad = new int[12];
            for (int i = 0; i < 6; i++)
            {
                string carta= mano[i];
                char rango = carta[0];

                if (rango == 'A')
                {
                    cantidad[0]++;
                }
                else if (rango == 'K')
                {
                    cantidad[1]++;
                }
                else if (rango == 'Q')
                {
                    cantidad[2]++;
                }
                else if (rango == 'J')
                {
                    cantidad[3]++;
                }
                else if (rango=='T')
                {
                    cantidad[4]++;
                }
                else if (rango == '9')
                {
                    cantidad[5]++;
                }
                else if (rango == '8')
                {
                    cantidad[6]++;
                }
                else if (rango == '7')
                {
                    cantidad[7]++;
                }
                else if (rango == '6')
                {
                    cantidad[8]++;
                }
                else if (rango == '5')
                {
                    cantidad[9]++;
                }
                else if (rango == '4')
                {
                    cantidad[10]++;
                }
                else if (rango == '3')
                {
                    cantidad[11]++;
                }
                else if (rango == '2')
                {
                    cantidad[12]++;
                }
            }
            int pares = 0;
            bool trio = false;
            bool poker = false;
            for (int i = 0; i < 13; i++)
            {
                if (cantidad[i] == 2)
                {
                    pares++;
                }
                if (cantidad[i] == 3)
                {
                    trio = true;
                }
                if (cantidad[i] == 4)
                {
                    poker = true;
                }
            }
            string tipo = "Nada";
            if (poker == true)
            {
                tipo = "Poker";
            }
            else if (trio == true && pares==1)
            {
                tipo = "Full";
            }
            else if(trio==true)
            {
                tipo = "Trio";
            }
            else if(pares>=1)
            {
                tipo = "Par";
            }
            return tipo;
        }
        static int puntajeBase(string[] mano)
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                string carta = mano[i];
                char rango = carta[0];

                if (rango == 'A')
                {
                    total = +14;
                }
                else if (rango == 'K')
                {
                    total = +13;
                }
                else if (rango == 'Q')
                {
                    total = +12;
                }
                else if (rango == 'J')
                {
                    total = +11;
                }
                else if (rango == 'T')
                {
                    total = +10;
                }
                else
                {
                    total = +int.Parse(rango.ToString());
                }
            }
            return total;
        }
        static double multiplicador(string tipo)
        {
            double mult = 1.0;
            if (tipo == "Par")
            {
                mult = 1.5;
            }
            else if(tipo=="Trio")
            {
                mult = 2.5;
            }
            else if(tipo=="Full")
            {
                mult = 3.5;
            }
            else if(tipo=="Poker")
            {
                mult = 4.0;
            }
            return mult;
        }
        static double aplicarJokers(double puntaje, bool x2,bool mas_10)
        {

        }
    }
}
