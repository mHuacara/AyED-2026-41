using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Eternauta
{
    class Program
    {
        public void Main(string[] args)
        {
            Refugio Refugio101 = new Refugio(1, 20, 12);
            Refugio Refugio102 = new Refugio(2, 15, 10);
            Refugio Refugio103 = new Refugio(3, 30, 25);

        }
        class Refugio
        {
            private int codigo_de_refugio;
            private int capacidadMaxima;
            private int personasAlojadas;

            //Constructor
            public Refugio(int codigo_de_refugio, int capacidadMaxima, int personasAlojadas)
            {
                this.codigo_de_refugio = codigo_de_refugio;
                this.capacidadMaxima = capacidadMaxima;
                this.personasAlojadas = personasAlojadas;
            }
        }

        public void calcularDisponibles(int capacidadMaxima, int personasAlojadas)
        {
            capacidadMaxima -= personasAlojadas;
        }
        public void mostrarInformacion(int capacidadMaxima, int personasAlojadas)
        {
            int x = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Refugio " + x + " : ");
                Console.WriteLine(capacidadMaxima);
                Console.WriteLine(personasAlojadas);
                x++;
            }
        }
    }
}

    

