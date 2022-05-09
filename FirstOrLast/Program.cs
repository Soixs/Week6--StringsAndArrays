using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt sisestada ees- ja perekonnanime.
            //Programm kontrollib andmete pikkust
            //Programm kuvab kumb neist on pikem

            Console.WriteLine("Kuidas on teie eesnimi?");
            string eesNimi = Console.ReadLine();

            Console.WriteLine("  ");

            Console.WriteLine("Kuidas on teie perekonnanimi?");
            string perekNimi = Console.ReadLine();

            Console.WriteLine("  ");

            if (eesNimi.Length < perekNimi.Length)
                Console.WriteLine($"Sinu {perekNimi.Length} sümboliga perekonnanimi on pikem kui eesnimi.");

            else if (eesNimi.Length > perekNimi.Length)
                Console.WriteLine($"Sinu {eesNimi.Length} sümboliga eesnimi on pikem kui perekonnanimi.");

            else
                Console.WriteLine($"Mõlemas on {eesNimi.Length} arv sümboleid - WoW!");

        }
    }
}
