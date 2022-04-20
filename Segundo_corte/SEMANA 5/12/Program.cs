using System;

namespace PRUEBA_RELOJ
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[,] matriz=new int[4,4];
            int n=1;
            for(int k=0;k<4;k++)
            {for (int f = 0; f <4; f++)
            {
                if(k!=n-1)
                {
                    matriz[k,f] =random.Next(1,4);
                }
            }
            }
            Console.WriteLine("matriz inicial");
            for(int k=0;k<4;k++)
            {
                for (int f = 0; f <4; f++)
                {
                Console.Write(" | " +matriz[k,f]+ " | ");
                }
                Console.WriteLine();
            }
           
            Console.WriteLine("");
            Console.WriteLine("matriz final");
            for(int k=1;k<4;k++)
            { int f;
                for (f = 0; f < 4; f++)
                {
                Console.Write(" | " +matriz[k,f]+" | ");
                }
                 
                  Console.WriteLine();
            }
            for (int k = 0; k < 1; k++)
            {
                for (int f = 0; f < 4; f++)
              {
                Console.Write(" | " +matriz[k,f]+" | ");
              }
                
            }
        }
    }
}