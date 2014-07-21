using System;
using System.Numerics;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter positive integer n : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }