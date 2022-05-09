using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm asendab kõik 'o' tähed lauses "Hello World!" tärniga '*'

            string lause = "Hello World!";

            //
            //for(int i = 0; i < lause.Length; i++)
            //lause[i] = '*';

            lause = lause.Replace('o', '*');
            lause = lause.Replace('!', '1');
            Console.WriteLine(lause);
        }
    }
}
