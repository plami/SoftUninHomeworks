using System;

    class NumberFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

