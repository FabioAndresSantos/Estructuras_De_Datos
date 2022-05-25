using System;

namespace PadRight
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstMessage;
            firstMessage = "Hello world in english";
            Console.Write("|");
            Console.Write(firstMessage.PadRight(5));
            Console.WriteLine("|");
        }
    }
}
