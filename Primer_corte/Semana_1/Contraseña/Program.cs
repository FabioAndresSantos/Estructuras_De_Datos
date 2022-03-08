using System;
using System.Text;

namespace Contraseña
{
    class Program
    {
       

        static void Main(string[] args)
        {
            String con;
            float swich = 0;
            string clave ="iloveyou123";
            while (swich == 0)
            {
                Console.WriteLine("Ingrese la contraseña");
                con = Console.ReadLine();
                if (con== clave)
                {
                    Console.WriteLine("La clave es correcta");
                    swich++;
                }
                else
                {
                    Console.WriteLine("La contraseña es incorrecta");
                    swich = 0;
                }



            }
        }
    }
}
