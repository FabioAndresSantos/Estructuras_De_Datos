using System;
namespace Conversion_Tiempo
{
    public class Programa
    {
        static void Main(string[] args)
        {
            float s = 0;
            System.Console.WriteLine("Regalame el numero en segundos");
            s = float.Parse(System.Console.ReadLine());
            float m = s * 60;
            float h = s * 3600;
            float d = s * 86400;
            System.Console.WriteLine("La cantidad de segundos son {0}, de minutos son {1}, de horas son {2}, de días son {3}", s, m, h, d);
        }
    }
}
