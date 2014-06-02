using System;

    class ExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Enter an unsigned integer:");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of n is:");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            uint moveNumber = number >> 3;
            uint bit = moveNumber & 1;
            Console.WriteLine("The value of the bit #3 is: ");
            Console.WriteLine(Convert.ToString(bit, 2));
        }
    }
