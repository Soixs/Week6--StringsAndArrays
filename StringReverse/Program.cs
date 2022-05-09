using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab kasutaja eesnime tagurpidi

            Console.WriteLine("Sisesta eesnimi?");
            string eesNimi = Console.ReadLine();

            for (int i = eesNimi.Length - 1; i >= 0; i--)
            {
                Console.Write(eesNimi[i]);
            }
        }
    }
}
