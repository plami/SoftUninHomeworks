using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the Fibonacci sequence: ");
            int length = int.Parse(Console.ReadLine());

            int numberA = 0;
            int numberB = 1;
            int sum = 1;
            Console.Write(numberA + " ");
            Console.Write(numberB + " ");

            for (int i = 2; i < length; i++)
            {
                sum = numberA + numberB;
                Console.Write(sum + " ");
                numberA = numberB;
                numberB = sum;
            }
            Console.WriteLine();
        }
    }

