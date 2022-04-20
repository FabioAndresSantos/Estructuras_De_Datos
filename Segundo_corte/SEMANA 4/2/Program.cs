using System;
namespace p_2
{
    class program
    {
      int []tamaño;
      int sum,ta;
      Random nr = new Random();
      public void carga()
      {
         Console.WriteLine("digite el tamaño del arreglo");
         ta=int.Parse(Console.ReadLine());
         tamaño=new int[ta];

         Console.WriteLine("");
        for (int i = 0; i < tamaño.Length; i++)
        {
            tamaño[i]=nr.Next (0,10);
            Console.WriteLine($"el arreglo va en la posicion {i} \n el numero generado es {tamaño[i]}\n");
        }
      }
      private void mostrar()
      {   
          for (int i = 0; i < tamaño.Length; i++)
          {
             sum+=tamaño[i]; 
            Console.WriteLine($"el numero generado es: {tamaño[i]}\nla suma de los numeros es: {sum} \n "); 
          }
      }
        static void Main (string []args)
        {
          program ran=new program();
          ran.carga();
          ran.mostrar();
        }
    }
}