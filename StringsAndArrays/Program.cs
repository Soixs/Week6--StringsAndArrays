using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja eesnime
            //Kuvab kasutaja eesnime pikkuse

            Console.WriteLine("Kuidas on teie eesnimi?");
            string eesNimi = Console.ReadLine();

            Console.WriteLine("  ");

            Console.WriteLine($"Sinu eesnimes on täpselt {eesNimi.Length} sümbolit");

        }
    }
}
