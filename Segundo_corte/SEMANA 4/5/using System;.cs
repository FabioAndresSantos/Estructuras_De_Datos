using System;

namespace Punt_5
{
    class Program
    {
        static void Main(string[] args)
        {
          
          int num1 = 0;
          int num2 = 0;         
           Console.WriteLine(" ingrese la cantidad de letras que desea ingresar:");
          num2 = Convert.ToInt32(Console.ReadLine());
          for(int j = 0; j< num2; j++){

          
          char[] Abecedario;
          Abecedario = new char [27];
          Abecedario[0] = 'A';
          Abecedario[1] = 'B';
          Abecedario[2] = 'C';
          Abecedario[3] = 'D';
          Abecedario[4] = 'E';
          Abecedario[5] = 'F';
          Abecedario[6] = 'G';
          Abecedario[7] = 'H';
          Abecedario[8] = 'I';
          Abecedario[9] = 'J';
          Abecedario[10] = 'K';
          Abecedario[11] = 'L';
          Abecedario[12] = 'M';
          Abecedario[13] = 'N';
          Abecedario[14] = 'Ñ';
          Abecedario[15] = 'O';
          Abecedario[16] = 'P';
          Abecedario[17] = 'Q';
          Abecedario[18] = 'R';
          Abecedario[19] = 'S';
          Abecedario[20] = 'T';
          Abecedario[21] = 'U';
          Abecedario[22] = 'V';
          Abecedario[23] = 'W';
          Abecedario[24] = 'X';
          Abecedario[25] = 'Y';
          Abecedario[26] = 'Z';

        
          if( num1 < 26){
          Console.WriteLine("Por favor ingrese un numero .");
          num1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Su letra es: "+Abecedario[num1]);
                     }
          }
         Console.ReadKey();

        }
    }
}
