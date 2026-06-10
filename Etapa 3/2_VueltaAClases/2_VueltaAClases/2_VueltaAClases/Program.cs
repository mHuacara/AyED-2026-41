using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad_tps;
            int cantidad_examenes;
            int num = 1;
            int nota_total_tps = 0;
            int nota_total_examenes = 0;
            float promedio_tps;
            float promedio_examenes;
            float porcentaje;
            Console.WriteLine("Te preguntaremos sobre tu situacion escolar ");
            Console.Write("Cuantos trabajos practicos tienen en la materia que quieren saber?: ");
            cantidad_tps = int.Parse(Console.ReadLine());
            Console.Write("Cuantos examenes tienen en la materia?");
            cantidad_examenes = int.Parse(Console.ReadLine());
            int[] nota_tps = new int[cantidad_tps];
            for(int i=0;i<cantidad_tps;i++)
            {
                Console.Write("Cuanto te sacaste en el tp numero " + num + " ?:");
                nota_tps[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                num++;
            }
            int[] nota_examen = new int[cantidad_examenes];
            for (int n = 0; n < cantidad_examenes; n++)
            {
                Console.Write("Cuanto te sacaste en el examen numero " + num + "(nota maxima 10) ?: ");
                nota_tps[n] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                num++;
            }
            for (int k = 0; k < cantidad_tps; k++)
            {
                nota_total_tps = nota_total_tps + nota_tps[k];
            }
            for (int m = 0; m < cantidad_examenes; m++)
            {
                nota_total_examenes = nota_total_examenes + nota_examen[m];
            }
            promedio_tps = nota_total_tps / cantidad_tps;
            promedio_examenes = nota_total_examenes / cantidad_examenes;
        
            if(promedio_examenes>=6 &&
            {

            }
            Console.Write(promedio_tps);
            Console.Write(promedio_examenes);

            Console.ReadKey();
        }

    }
}
