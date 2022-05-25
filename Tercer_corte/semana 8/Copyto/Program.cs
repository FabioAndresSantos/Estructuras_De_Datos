using System;

namespace Copyto
{
    class Program
    {
        static void Main(string[] args)
        {
            String copiasDeRecursos = "Changed";
            char[] cadenaDePalabras = { 'I', 'n','i','t','i','a','l',' ', 'm','e','n','s','a','j','e'};
            Console.WriteLine(cadenaDePalabras);
            copiasDeRecursos.CopyTo(0, cadenaDePalabras,0, copiasDeRecursos.Length);
            Console.WriteLine(cadenaDePalabras); 
        }
    }
}
