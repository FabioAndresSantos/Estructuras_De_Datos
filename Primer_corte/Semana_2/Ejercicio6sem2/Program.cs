using System;

namespace Ejercicio6sem2
{
    class Program
    {
        static void Main(string[] args)
        { 
            String D1;
        String a = "1", b = "2", c = "3", d = "4", e = "5", f = "6", g = "7", h = "8", i = "9", j = "0";
        String A = "uno", B = "dos", C = "tres", D = "cuatro", E = "cinco", F = "seis", G = "siete", H = "ocho", I = "nueve", J = "cero";
        Console.WriteLine("Elija uno tenga en cuenta que solo van hasta el 20 ;) ");
            Console.WriteLine("letras");
            Console.WriteLine("numero");
            D1 = Console.ReadLine();

            if (D1 == "letras")
            {
                Console.WriteLine("escriba el numero en letras");
                D1 = Console.ReadLine();
                if (D1 == "cero")
                    Console.WriteLine("el Numeros es " + j);
                if (D1 == "uno")
                    Console.WriteLine("El numero es  " + a);
                if (D1 == "dos")
                    Console.WriteLine("El numero es  " + b);
                if (D1 == "tres")
                    Console.WriteLine("El numero es  " + c);
                if (D1 == "cuatro")
                    Console.WriteLine("El numero es  " + d);
                if (D1 == "cinco")
                    Console.WriteLine("El numero es  " + e);
                if (D1 == "seis")
                    Console.WriteLine("El numero es  " + f);
                if (D1 == "siete")
                    Console.WriteLine("El numero es  " + g);
                if (D1 == "ocho")
                    Console.WriteLine("El numero es  " + h);
                if (D1 == "nueve")
                    Console.WriteLine("El numero es  " + i);
                if (D1 == "diez")
                    Console.WriteLine("El numero es  " + j);
                if (D1 == "once")
                    Console.WriteLine("El numero es " + a + a);
                if (D1 == "doce")
                    Console.WriteLine("El numero es" + a + b);
                if (D1 == "trece")
                    Console.WriteLine("El numero es " + a + c);
                if (D1 == "catorce")
                    Console.WriteLine("El numero es " + a + d);
                if (D1 == "quince")
                    Console.WriteLine("El numero es " + a + e);
                if (D1 == "dieciseis")
                    Console.WriteLine("El numero es " + a + f);
                if (D1 == "Diecisiete")
                    Console.WriteLine("El numero es " + a + g);
                if (D1 == "dieciocho")
                    Console.WriteLine("El numero es " + a + h);
                if (D1 == "diecinueve")
                    Console.WriteLine("El numero es " + a + i);
                if (D1 == "veinte")
                    Console.WriteLine("El numero es " + b + j);
            }

            else if (D1 == "numero")
            {
                Console.WriteLine("escriba el numero");
                D1 = Console.ReadLine();
                if (D1 == "0")
                    Console.WriteLine("El numero es " + J);
                if (D1 == "1")
                    Console.WriteLine("El numero es  " + A);
                if (D1 == "2")
                    Console.WriteLine("El numero es  " + B);
                if (D1 == "3")
                    Console.WriteLine("El numero es  " + C);
                if (D1 == "4")
                    Console.WriteLine("El numero es  " + D);
                if (D1 == "5")
                    Console.WriteLine("El numero es  " + E);
                if (D1 == "6")
                    Console.WriteLine("El numero es  " + F);
                if (D1 == "7")
                    Console.WriteLine("El numero es  " + G);
                if (D1 == "8")
                    Console.WriteLine("El numero es  " + H);
                if (D1 == "9")
                    Console.WriteLine("El numero es  " + A + I);
                if (D1 == "10")
                    Console.WriteLine("El numero es  " + J);
                if (D1 == "11")
                    Console.WriteLine("El numero es " + A + A);
                if (D1 == "12")
                    Console.WriteLine("El numero es" + A + B);
                if (D1 == "13")
                    Console.WriteLine("El numero es " + A + C);
                if (D1 == "14")
                    Console.WriteLine("El numero es " + A + D);
                if (D1 == "15")
                    Console.WriteLine("El numero es " + A + E);
                if (D1 == "16")
                    Console.WriteLine("El numero es " + A + F);
                if (D1 == "17")
                    Console.WriteLine("El numero es " + A + G);
                if (D1 == "18")
                    Console.WriteLine("El numero es " + A + H);
                if (D1 == "19")
                    Console.WriteLine("El numero es " + A + I);
                if (D1 == "20")
                    Console.WriteLine("El numero es " + B + J);
            }
        }
    }
}
        
           
