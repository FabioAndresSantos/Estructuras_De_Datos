using System;

namespace Ejer7sem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string   var= "i";
            string  var1= "p";
            int num1 = 0, num2 = 0;
            int i = 0;
            string ope = "";
            

            Console.WriteLine("Ingrese primer número");
            num1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese segundo número");
            num2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese que operacion desea´p´ para pares y ´i´para impares");
            ope = Console.ReadLine();
            if (ope == var1)
            {
                if (num1 % 2 == 0)
                {
                    for (i = num1 ; i <= num2; i += 2)
                    {
                        Console.WriteLine($"El numero inicial es {num1} y termina en {i}");
                    }
                }
                else
                {
                    for (i = num1 + 1; i <= num2; i += 2)
                    {
                        Console.WriteLine($"El numero inicial es {num1} y termina en {i}");
                    }
                }
            }
                if (ope == var)
                {
                if (num1 % 2 == 1) { 
                
                    for (i = num1; i <= num2; i += 2)
                    {
                        Console.WriteLine($"El numero inicial es {num1} y termina en {i}");
                    }
                }
                else {
                    for (i = num1 + 1;i<= num2; i += 2)
                    {
                        Console.WriteLine($"El numero inicial es {num1} y termina en {i}");
                    }
                }
            }
           if(ope != var && ope != var1)
            {
                Console.WriteLine("El caracter no es valido ");
            }
        }
   }
}
