using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            int diezmil = 0;
            int dosmil = 0;
            int mil = 0;
            int quinientos = 0;
            int doscientos = 0;
            int cien = 0;
            int cincuenta = 0;
            int veinte = 0;
            int diez = 0;
            int gasto;
            int vuelto;
            int monto;
            Console.WriteLine("Le preguntaremos cuanto debio pagar");
            Console.Write("Que monto tuvo que pagar?: ");
            monto = int.Parse(Console.ReadLine());
            Console.Write("Con cuanto pago?: ");
            gasto = int.Parse(Console.ReadLine());
            vuelto = gasto - monto;
            Console.WriteLine("Su vuelto: " + vuelto);
            while (vuelto >= 10000)
            {
                diezmil = diezmil + 1;
                vuelto = vuelto - 10000;
            }
            while (vuelto >= 2000)
            {
                dosmil = dosmil + 1;
                vuelto = vuelto - 2000;
            }
            while(vuelto>=1000)
            {
                mil = mil + 1;
                vuelto = vuelto - 1000;
            }
            while(vuelto>=500)
            {
                quinientos = quinientos + 1;
                vuelto = vuelto - 500;
            }
            while(vuelto>=200)
            {
                doscientos = doscientos + 1;
                vuelto = vuelto - 200;
            }
            while(vuelto>=100)
            {
                cien = cien + 1;
                vuelto = vuelto - 100;
            }
            while (vuelto >= 50)
            {
                cincuenta = cincuenta + 1;
                vuelto = vuelto - 50;
            }
            while (vuelto >= 20)
            {
                veinte = veinte + 1;
                vuelto = vuelto - 20;
            }
            while (vuelto >= 10)
            {
                diez = diez + 1;
                vuelto = vuelto - 10;
            }
            Console.WriteLine("Cantidad de billetes de 10000 usados: " + diezmil);
            Console.WriteLine("Cantidad de billetes de 2000 usados: " + dosmil);
            Console.WriteLine("Cantidad de billetes de 1000 usados: " + mil);
            Console.WriteLine("Cantidad de billetes de 500 usados: " + quinientos);
            Console.WriteLine("Cantidad de billetes de 200 usados: " + doscientos);
            Console.WriteLine("Cantidad de billetes de 100 usados: " + cien);
            Console.WriteLine("Cantidad de billetes de 50 usados: " + cincuenta);
            Console.WriteLine("Cantidad de billetes de 20 usados: " + veinte);
            Console.WriteLine("Cantidad de billetes de 10 usados : " + diez);
            Console.ReadKey();


        }
    }
}
