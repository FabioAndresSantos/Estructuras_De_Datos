using System;

namespace Ejercicio3
{
    class Program
    {
        private int[,] Matriz;
        int longitudFila;
        int longitudColumna;
        int limiteNumero;

        public void cargarMatriz()
        {
            Console.WriteLine("Ingrese la longitud de la fila");
            longitudFila = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese la longitud de la columna");
            longitudColumna = int.Parse(System.Console.ReadLine());
            Matriz = new int[longitudFila, longitudColumna];
            Console.WriteLine("Ingrese el número maximo");
            limiteNumero = int.Parse(System.Console.ReadLine());
            for (int f = 0; f < longitudFila; f++)
            {
                for (int c = 0; c < longitudColumna; c++)
                {
                    Random numAleatorio = new Random();
                    Matriz[f, c] = numAleatorio.Next(1, limiteNumero);
                    
                }
            }
        }
        public void mostrarMatriz()
        {
            Console.WriteLine("\nLa matriz resultante es");
            for (int f = 0; f < Matriz.GetLength(0); f++)
            {
                for (int c = 0; c < Matriz.GetLength(1); c++)
                {
                    Console.Write("    [" + Matriz[f,c] + "] ");
                }
                Console.WriteLine();
            }
        }
        public void determinarMayor()
        {
            int ELEMENTO_MAYOR = Matriz[0, 0];
            int filaMayor = 0;
            int columnaMayor = 0;

            for (int f = 0; f < Matriz.GetLength(0); f++)
            {
                for (int c = 0; c < Matriz.GetLength(1); c++)
                {
                    if (Matriz[f, c] > ELEMENTO_MAYOR)
                    {
                        ELEMENTO_MAYOR = Matriz[f, c];
                        filaMayor = f;
                        columnaMayor = c;
                    }
                }
            }
            Console.WriteLine("El elemento mayor de la matriz de [" + Matriz.GetLength(0) + "] x [" + Matriz.GetLength(1) + "] es : [" + ELEMENTO_MAYOR + "]");
            Console.WriteLine("Se encuentra en la fila: [" + (filaMayor + 1) + "] columna: [" + (columnaMayor + 1) + "]");

        }
        public void determinarMenor()
        {
            int ELEMENTO_MENOR = Matriz[0, 0];
            int filaMenor = 0;
            int columnaMenor = 0;
            for (int f = 0; f < Matriz.GetLength(0); f++)
            {
                for (int c = 0; c < Matriz.GetLength(1); c++)
                {
                    if (Matriz[f, c] < ELEMENTO_MENOR)
                    {
                        ELEMENTO_MENOR = Matriz[f, c];
                        filaMenor = f;
                        columnaMenor = c;
                    }
                }
            }
            Console.WriteLine("El elemento menor de la matriz de [" + Matriz.GetLength(0) + "] x [" + Matriz.GetLength(1) + "] es : [" + ELEMENTO_MENOR + "]");
            Console.WriteLine("Se encuentra en la fila: [" + (filaMenor+1)+ "] columna:[" + (columnaMenor+1 ) + "]");
        }

        static void Main(string[] args)
        {
            Program matrices = new Program();
            matrices.cargarMatriz();
            matrices.mostrarMatriz();
            matrices.determinarMayor();
            matrices.determinarMenor();

        }
    }
}
