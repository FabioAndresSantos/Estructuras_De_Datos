using System;

namespace Ejer12sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = 0, c2 = 0, c3 = 0, Nu, Vo = 0;
            Random Nuv = new Random();
            Vo = Nuv.Next(20, 70);
            Console.WriteLine("bienvenido a las votaciones");
            Console.WriteLine("los candidatos son:");
            Console.WriteLine("Andrea Martinez");
            Console.WriteLine("Daniel torres");
            Console.WriteLine("Andry Ruiz");
            for (int i = 1; i <= Vo; i++)
            {
                Random Ran = new Random();
                Nu = Ran.Next(1, 4);
                if (Nu == 1)
                {
                    c1++;
                }
                if (Nu == 2)
                {
                    c2++;
                }
                if (Nu == 3)
                {
                    c3++;
                }
            }
            Console.WriteLine("han votado " + c1 + " por Andry Ruiz");
            Console.WriteLine("han votado " + c2 + " por Daniel Torres");
            Console.WriteLine("han votado " + c3 + " por Andrea Martinez");
            if (c1 > c2 && c1 > c3)
                Console.WriteLine("El candidato Andry ruiz ha ganado ");
            if (c2 > c1 && c2 > c3)
                Console.WriteLine("El candidato Daniel Torres ha ganado ");
            if (c3 > c1 && c3 > c2)
                Console.WriteLine("El candidato Andrea Martinez ha ganado ");
        }
    }
}
