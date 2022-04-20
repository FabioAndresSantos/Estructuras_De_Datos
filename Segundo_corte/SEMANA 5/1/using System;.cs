using System;

namespace Ejercicio_1
{
    class Program
    {
        int[,] mat;
        public void Ingresar(){
            mat = new int[4, 5];
            for (int f =0; f < 4; f++){

                for (int c= 0; c < 5; c++){
                 Console.WriteLine("ingrese un numero para la posicion "+ (f + 1) + ","+ (c + 1)+ ": ");
                 mat[f, c] = int.Parse(Console.ReadLine());
                }
                }
            }
        public void Imprimir(){
         Console.WriteLine("SU MATRIZ ES:");
            for (int f = 0; f < 4; f++){
                  for (int c=0; c < 5; c++){
                  Console.Write($"[ {mat[f, c]} ]");
                }
                Console.WriteLine();
            }
            }
        public void Sumar_filas(){
         int filas = 0;
         int filas2 = 0;
         int suma = 0;
         Console.WriteLine("Por favor escriba el numero de filas para sacar la suma correspondiente de cada una: ");
         filas = Convert.ToInt32(Console.ReadLine());
         if(filas < 4 ){
             for(int fi = 0; fi < filas; fi++){
               Console.WriteLine("Por favor escriba el numero de la fila de la cual desea hacer la suma");
               filas2 = Convert.ToInt32(Console.ReadLine());

               if(filas2 >= 0 && filas2 < mat.GetLength(0)){
                   for(int i = 0; i < mat.GetLength(0); i++){
                   suma = suma + mat[filas2,i];
                   }
                 Console.WriteLine("La suma de la fila es: "+ suma);
                 
               }
               
            }
         }
         else{
         Console.WriteLine("La fila no es valida");
         }
         
        }
        public void Sumar_Columnas(){
         int columnas = 0;
         int columnas2 = 0;
         int suma1 = 0;
         Console.WriteLine("escriba el numero de columnas para sacar la suma correspondiente de cada una: ");
         columnas = Convert.ToInt32(Console.ReadLine());

         if(columnas < 4 ){
             for(int co = 0; co < columnas; co++){
               Console.WriteLine(" escriba el numero de la columns de la cual desea hacer la suma:");
               columnas2 = Convert.ToInt32(Console.ReadLine());
               if(columnas2 >= 0 && columnas2 < mat.GetLength(1)){
                   for(int i = 0; i < mat.GetLength(1); i++){
                   suma1 = suma1 + mat[i,columnas2];
                   }
                 Console.WriteLine("La suma de la columna es: "+ suma1);
                  }
               }
         }
         else{
         Console.WriteLine("La fila no es valida");
         }
        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Ingresar();
            pv.Imprimir();
            pv.Sumar_filas();
            pv.Sumar_Columnas();
        }
    }
}
