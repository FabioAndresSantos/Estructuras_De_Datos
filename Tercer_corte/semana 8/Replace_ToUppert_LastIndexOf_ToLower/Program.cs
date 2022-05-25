using System;
class metod
{
    static void remplazo()
    {
        //se solicita una frase para empezar el programa
        Console.WriteLine("Digite una frase");
        string Cadena = Console.ReadLine();
        //se solicita una palabra 
        Console.WriteLine("Digite una palabra que desea cambiar");
        string a = Console.ReadLine();
        Console.WriteLine("digite una palabra que desea agregar");
        string b = Console.ReadLine();
        //Remplaza la palabra seleccionada por el usuario por la que el usuario digito finalmente 
        Cadena = Cadena.Replace(a, b);
        Console.WriteLine(Cadena, "\n");
    }

    static void buscando()
    {
        //Se solicita una nueva frase
        Console.WriteLine("\nDigite una frase");
        string Cadena = Console.ReadLine();
        //se le solicita una palabra a buscar 
        Console.WriteLine("Digite una palabra a buscar");
        String buscar = Console.ReadLine();
        //El programa busca en que posicion esta la palabra o caracter solicitado
        int lugar = Cadena.LastIndexOf(buscar);
        //si lugar es diferente de -1 encontro la palabra o caracter y entra a la condicion
        if (lugar != -1)
        {
            Console.WriteLine($"Se encontro en la posicion {lugar}");
            Console.WriteLine($"La frase es {Cadena} y la palabra buscada esta en la poscicion {lugar}");
        }
        //el programa no encotro la palabra ya que lugar vale -1
        else
        {
            Console.WriteLine("No se encontro la palabra");
            Console.WriteLine($"La frase es {Cadena} y la palabra buscada mo existe");
        }
    }
    static void mayuscula()
    {
        //Se solicita una nueva frase para pasarla a mayusculas
        Console.WriteLine("\nDigite una frase para pasarla a mayusculas");
        string Cadena = Console.ReadLine();
        //se le usa el metodo para pasar palabras a mayuscula
        string mayusculas = Cadena.ToUpper();
        Console.WriteLine($"La frase que ha digitado es \n{mayusculas}");
    }
    static void minusculas()
    {
        //Se solicita una nueva frase para pasarla a minusculas
        Console.WriteLine("\nDigite una frase para pasarla a minusculas");
        string Cadena = Console.ReadLine();
        //se le usa el metodo para pasar palabras a minusculas
        string minusculas = Cadena.ToLower();
        Console.WriteLine($"La frase que ha digitado es \n{minusculas}");

    }

    public static void Main(string[] args)
    {
        metod inicio = new metod();
        metod.remplazo();
        metod.buscando();
        metod.mayuscula();
        metod.minusculas();
    }
}


