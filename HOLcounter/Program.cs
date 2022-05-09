using System;

namespace HOLcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello world!"

            int hCount = 0;
            int oCount = 0;
            int lCount = 0;

            string lause = "Hello World!".ToLower();

            for (int i = 0; i < lause.Length; i++)
            {
                Console.WriteLine(lause[i]);
                if (lause[i] == 'h')
                {
                    hCount++;
                }
                else if (lause[i] == 'o')
                {
                    oCount++;
                }
                else if (lause[i] == 'l')
                {
                    lCount++;
                }
            }
            Console.WriteLine("  ");
            Console.WriteLine($"Lauses on {hCount} -H, {oCount} -O tähte ja {lCount} -L tähte");

        }
    }
}
