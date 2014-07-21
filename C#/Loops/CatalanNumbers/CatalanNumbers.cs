using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial2NtoSum = 1;
            BigInteger factorialN = 1;
            BigInteger result = 0;

            if (n < 1 && n > 100)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                for (int i = 2 * n; i > n + 1; i--)
                {
                    factorial2NtoSum *= i;
                }
                for (int j = 1; j <= n; j++)
                {
                    factorialN *= j;
                }
                result = factorial2NtoSum / factorialN;
                Console.WriteLine("(2n)!/(n + 1)! * n! = " + result); 
            }
            Console.WriteLine();
        }
    }
