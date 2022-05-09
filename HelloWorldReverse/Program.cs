using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab lauset "Hello, World!" tagurpidi

            string lause = "Hello, World!";

            for (int i = lause.Length - 1; i >= 0; i--)
            {
                Console.Write(lause[i]);
            }
            Console.WriteLine("  ");
        }
    }
}
