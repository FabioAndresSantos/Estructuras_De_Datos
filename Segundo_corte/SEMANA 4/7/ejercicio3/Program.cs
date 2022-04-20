using System;
namespace p_3
{
    class program
    {
        double [] num = new double[10];
        double nt;
        string[] txt = new string[10];

        public void condi()
        {
            for (int i = 0; i < txt.Length; i++)
            {
                Console.WriteLine("\n Digite el nombre del estudiante");
                txt[i] = Console.ReadLine(); 
                Console.WriteLine($"digite la nota del estudiante: ");
                string texto= Console.ReadLine();
                nt = double.Parse(texto);
                num[i]=nt;
                
               if(num[i] == 0 || num[i] <= 4.99)
                {
                    Console.WriteLine($"la nota del estudiante {txt[i]} es: {num[i]}");
                    Console.WriteLine("El estudiante tiene un promedio insuficiente ");
                }
                else if (num[i] ==5 || num[i] < 6.99)
                {
                    Console.WriteLine($"la nota del estudiante {txt[i]} es: {num[i]}");
                    Console.WriteLine("El estudiante tiene un promedio aceptable ");
                }
                else if (num[i] == 7 || num[i] <= 8.99)
                {
                    Console.WriteLine($"la nota del estudiante {txt[i]} es: {num[i]}");
                    Console.WriteLine("El estudiante tiene un promedio sobresaliente ");
                }
                else if (num[i] == 9 || num[i] <= 10)
                {
                    Console.WriteLine($"la nota del estudiante {txt[i]} es: {num[i]}");
                    Console.WriteLine("El estudiante tiene un promedio excelente");
                }
            } 
        }
        static void Main(string[] args)
        {
            program not = new program();
            
            not.condi();
        }
    }
}
