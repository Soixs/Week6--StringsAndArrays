using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja ees- ja perekonnanime
            //Programm kuvab mitu a-tähte on kasutaja ees või perekonnanimes

            Console.WriteLine("Kuidas on teie eesnimi?");
            string eesNimi = Console.ReadLine().ToLower();
            Console.WriteLine("  ");
            Console.WriteLine("Kuidas on teie perekonnanimi?");
            string perekNimi = Console.ReadLine().ToLower();
            Console.WriteLine("  ");

            int aCounter = 0;

            for (int i = 0; i < eesNimi.Length; i++)
            {
                Console.WriteLine(eesNimi[i]);
                if (eesNimi[i] == 'a')
                {
                    aCounter++;
                }

            }

            Console.WriteLine("  ");

            for (int i = 0; i < perekNimi.Length; i++)
            {
                Console.WriteLine(perekNimi[i]);
                if (perekNimi[i] == 'a')
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
            }



        }
    }
}
