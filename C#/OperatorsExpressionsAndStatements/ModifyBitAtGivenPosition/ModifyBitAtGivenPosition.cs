using System;

    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter integer number n: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index p: ");
            int indexP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 0 or 1 for the bit at position index p: ");
            int bitValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of n is: ");
            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));

            int mask = bitValue << indexP;
            int result = numberN | mask;
            if (bitValue == 0)
            {
                mask = ~(1 << indexP);
                result = numberN & mask;
            }
            Console.WriteLine("Binary result is: ");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("Result is: ");
            Console.WriteLine(result);
        }
    }

