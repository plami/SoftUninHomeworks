using System;

    class NumbersInIntervalDividableByNumbers
    {
        static void Main()
        {
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + ",");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} numbers dividable by 5!",count);
        }
    }

