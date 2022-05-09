using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm asendab kõik 'o' tähed lauses "Don´t Panic" nulliga - 0
            //Programm asendab kõik 'a' tähed lauses "Don´t Panic" neljaga - 4

            Console.WriteLine("Don´t Panic!");
            Console.WriteLine(" ");
            string lause = "Don´t Panic!";
            lause = lause.Replace('o', '0');
            lause = lause.Replace('a', '4');
            Console.WriteLine(lause);
            Console.WriteLine(" ");
        }
    }
}
