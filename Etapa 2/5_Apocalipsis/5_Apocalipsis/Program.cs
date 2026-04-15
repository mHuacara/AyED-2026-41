using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool comida;
            bool refugio;
            bool bateria;
            bool botiquin;
            bool agua;
            bool linterna;
            bool bate;
            Console.WriteLine("Le diremos si puede vivir en un apocalipsis");
            Console.WriteLine("Le preguntaremos si tiene los siguientes elemetos,ingresar True(si) o False(no): ");
            Console.Write("Tiene comida?: ");
            comida = bool.Parse(Console.ReadLine());
            Console.Write("Tiene refugio?: ");
            refugio = bool.Parse(Console.ReadLine());
            Console.Write("Tiene bateria?: ");
            bateria = bool.Parse(Console.ReadLine());
            Console.Write("Tiene botiquin?: ");
            botiquin = bool.Parse(Console.ReadLine());
            Console.Write("Tiene agua?: ");
            agua = bool.Parse(Console.ReadLine());
            Console.Write("Tiene linterna?: ");
            linterna = bool.Parse(Console.ReadLine());
            Console.Write("Tiene un bate?:");
            bate = bool.Parse(Console.ReadLine());
            if(comida==true && agua==true && botiquin ==true || comida==true && agua==true && bate==true || bateria==true && comida==true  && agua==true && refugio==true)
            {
                Console.Write("Usted si podra sobrevivir");
            }
            else
            {
                Console.Write("Que pena,morira pronto");
            }
            Console.ReadKey();

        }
    }
}
