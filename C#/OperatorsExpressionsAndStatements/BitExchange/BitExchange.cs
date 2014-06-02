using System;

    class BitExchange
    {
        static void Main()
        {
            Console.WriteLine("Enter number n: ");
            uint numberN = uint.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of n is: ");
            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
            uint mask1 = ((7 << 3) | (7 << 24)) & numberN;
            uint mask2 = (mask1 << 21) | (mask1 >> 21);
            uint result = ((numberN & (~mask1)) | mask2);

            Console.WriteLine("Binary result is: ");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("Result is: ");
            Console.WriteLine(result);
        }
    }

