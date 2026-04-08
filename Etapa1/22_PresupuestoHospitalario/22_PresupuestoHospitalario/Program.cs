using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double ginecologia;
            double traumatologia;
            double pediatria;
            double sueldoanual;
            Console.WriteLine("Le solicitaremos el presupuesto anual de un hospital");
            Console.Write("Ponga el sueldo anual de un hospital: ");
            sueldoanual = double.Parse(Console.ReadLine());
            ginecologia = sueldoanual * 0.40;
            traumatologia = sueldoanual*0.30;
            pediatria = sueldoanual * 0.30;
            Console.Write("Segun el sueldo anual ginecologia recibe " + ginecologia + "$ y traumatologia recibe " + traumatologia + "$ y pediatria recibe " + pediatria + "$");
            Console.ReadKey();

        }
    }
}
