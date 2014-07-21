using System;
using System.Numerics;

    class Calculate_TwoLoops
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialNtoK = 1;
            BigInteger divider = 1;
            BigInteger result = 0;

            if (k < 1 || n < 1 || k > 100 || n > 100 || k > n)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                for (int i = n; i > k; i--)
                {
                    factorialNtoK *= i;
                }
                for (int j = 1; j <= n - k ; j++)
                {
                    divider *= j;
                }
                result = factorialNtoK / divider;
                Console.WriteLine("n! / k! * (n - k)! = " + result);
            }
            Console.WriteLine();
        }
    }

