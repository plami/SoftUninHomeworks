using System;

    class RandomizeNumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter n numbers : ");
            int numberN = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < numberN; i++)
            {
               Console.Write("{0} ", rnd.Next(1, numberN+1));
            }
            Console.WriteLine();
        }
    }

