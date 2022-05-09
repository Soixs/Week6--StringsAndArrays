using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm ennustab, mis puuvilja kasutaja sööb

            //Variant 1: string[] fruit = new string[5];

            //Variant 2:

            string[] fruit = new string[5] { "an apple", "a banana", "an orange", "a lemon", "cherries" };

            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);
            //jne...

            //Console.WriteLine("Please enter a number corresponding to a fruit");

            Random rnd = new Random();
            int userChoice = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userChoice]}");
        }
    }
}
