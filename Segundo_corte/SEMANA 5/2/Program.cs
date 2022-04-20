using System;
 namespace program
 {
    class p_2
    {
        Random rd= new Random();
        int [,] matriz=new int [6,6];
        
        string en="";
        public void num()
        { 
            Console.WriteLine("desea digitar los numeros");
            Console.WriteLine("digite  si o no");
            en=Console.ReadLine();
            if (en=="si")
            {

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
               for (int c = 0; c < matriz.GetLength(0); c++)
               {
                   Console.WriteLine("ingrese los datos ["+(f+1)+" "+(c+1)+"]:");
                   matriz[f,c] = int.Parse(Console.ReadLine());
               }
            }
            }
            else if (en=="no")
            {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
               for (int c = 0; c < matriz.GetLength(0); c++)
               {
                   matriz[f,c] =rd.Next(100,200);
               }
            }
            }
        }
        public void mostrar()
        { 
            Console.WriteLine("la matriz es");
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(0); c++)
             {
                Console.Write ("    "+matriz[f, c] +"   ");
             }
             Console.WriteLine();
            }
        }
        static void Main(string[]args)
        {
         p_2 ma =new p_2();
         ma.num();
         ma.mostrar();
        }
    }
 }