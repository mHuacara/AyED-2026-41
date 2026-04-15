using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña;
            string contraseña2 = "contraseña";
            Console.WriteLine("Le preguntaremos una contraseña");
            Console.Write("Por favor ponga la contraseña: ");
            contraseña = Console.ReadLine();
            if (contraseña2.ToLower() == contraseña.ToLower())
            {
                Console.Write("La contraseña esta bien ");
            }
            else
            {
                Console.Write("La contraseña esta mal");
            }
            Console.ReadKey();
        }
    }
}
