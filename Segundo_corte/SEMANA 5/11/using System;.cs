 using System;

namespace Ejercicio_2
{
    class Program
    {
        int LONGITUD_FILA=0;
        int LONGITUD_COLUMNA=0;
        int[,] Matriz;
        int LONGITUD_FILA2=0;
        int LONGITUD_COLUMNA2=0;
        int[,] Matriz2;
       


        public void Cargar_Matriz()
        {
            
         Console.WriteLine("Ingrese el número de filas de la matriz: ");
         LONGITUD_FILA = int.Parse(Console.ReadLine());
        
         Console.WriteLine("Ingrese el número de columnas de la matriz: ");
         LONGITUD_COLUMNA = int.Parse(Console.ReadLine());

         Matriz = new int[LONGITUD_FILA,LONGITUD_COLUMNA];

            for(int n = 0; n <LONGITUD_FILA;n++)
            {
                for(int m = 0; m<LONGITUD_COLUMNA;m++){
                    Console.Write($"Ingrese el elemeneto {n+1}, {m+1}: ");
                    Matriz[n,m]=int.Parse(Console.ReadLine());
                }
            }
        }

        public void Cargar_Matriz2()
        {
            
         Console.WriteLine("Ingrese el número de filas de la segunda matriz: ");
         LONGITUD_FILA2 = int.Parse(Console.ReadLine());
           
         Console.WriteLine("Ingrese el número de columnas de la segunda matriz: ");
         LONGITUD_COLUMNA2 = int.Parse(Console.ReadLine());

         Matriz2 = new int[LONGITUD_FILA2,LONGITUD_COLUMNA2];

            for(int n = 0; n <LONGITUD_FILA2;n++)
            {
                for(int m = 0; m<LONGITUD_COLUMNA2;m++){
                    Console.Write($"Ingrese el elemeneto {n+1}, {m+1} :");
                    Matriz2[n,m]=int.Parse(Console.ReadLine());
                }
            }
        }
        public void Imprimir_Matriz()
        {
            Console.WriteLine();
            Console.WriteLine("La primera matriz es:");
            for(int n=0;n<LONGITUD_FILA;n++)
            {
                for(int m=0;m<LONGITUD_COLUMNA;m++)
                {
                    Console.Write($"[ {Matriz[n,m]} ]");
                }
                Console.WriteLine();
            }

        }
        public void Imprimir_Matriz2()
        {
            Console.WriteLine();
            Console.WriteLine("La segunda matriz es:");
            for(int n=0;n<LONGITUD_FILA2;n++)
            {
                for(int m=0;m<LONGITUD_COLUMNA2;m++)
                {
                    Console.Write($"[ {Matriz2[n,m]} ]");
                }
                Console.WriteLine();
            }

        }
        public void Transpuesta(){
         int[,] transpuesta = new int [LONGITUD_COLUMNA2, LONGITUD_FILA2];
         int[,] a = Matriz2;
         int x, y;
         Console.WriteLine("La transpuesta de la segunda matriz es: ");

         for( x = 0; x < LONGITUD_FILA2; x++){
             for(y=0; y < LONGITUD_COLUMNA2; y++){
                 transpuesta[y,x]= a[x,y];
             }
         }

         for( x = 0; x < LONGITUD_COLUMNA2; x++){
             for(y = 0; y < LONGITUD_FILA2; y++){
                 Console.Write($"[ {transpuesta[x,y]} ]");
             }
             Console.WriteLine();
         }
        }
        public void Suma(){
            Console.WriteLine("La suma de las matrices es: ");
         int c, v;
         int[,] A = Matriz;
         int[,] B = Matriz2;
         int[,] suma = new int[LONGITUD_FILA, LONGITUD_COLUMNA];


         for(c = 0; c < LONGITUD_FILA; c++){
             for(v = 0; v < LONGITUD_COLUMNA; v++){
             suma[c,v] = A[c,v] + B[c,v];
            }
         }
         for(c=0; c < LONGITUD_COLUMNA; c++){
          for(v = 0; v < LONGITUD_FILA; v++){
              Console.Write($"[ {suma[c,v]} ]");
          }
          Console.WriteLine();
         }
        }

        static void Main(string[] args)
        {
            Program pv = new Program ();
            pv.Cargar_Matriz();
            pv.Cargar_Matriz2();
            pv.Imprimir_Matriz();
            pv.Imprimir_Matriz2();
            pv.Transpuesta();
            pv.Suma();
        }
    }
}
