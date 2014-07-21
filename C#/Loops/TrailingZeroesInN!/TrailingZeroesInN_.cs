using System;
using System.Numerics;

    class TrailingZeroesInN_
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int trailingZeroes = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Explanation: {0}", factorial);

            while (factorial % 10 == 0)
            {
                factorial /= 10;
                trailingZeroes++;
            }
            Console.WriteLine("Trailing zeroes in n! {0}", trailingZeroes);
            Console.WriteLine();
        }
    }
