using System;

namespace Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstMessage = "Hello world";
            Console.WriteLine("Original message ", firstMessage);
            String modifiedMessage = firstMessage.Insert(6, "mundo");
            Console.WriteLine("Modified message", modifiedMessage);
        }
    }
}
