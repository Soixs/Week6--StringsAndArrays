using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm ennustab, mis juhtub homme kasutajaga (Random)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };

            Console.WriteLine("Soovid saada ennustust?");
            Console.WriteLine(" ");

            Random rnd = new Random();
            int userChoice = rnd.Next(0, predictions.Length);

            Console.WriteLine($" {predictions[userChoice]}!");

            Console.WriteLine(" ");

            Console.WriteLine("Kena päeva!");
        }
    }
}
