using System;

class CheckABitAtGivenPosition
{
    static void Main()
        {
            Console.WriteLine("Enter integer n: ");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index p: ");
            int indexP = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary represenations of n: ");
            Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
            int moveNumberN = numberN >> indexP;
            bool isBitValue1 = (moveNumberN & 1) == 1;
            Console.WriteLine("Does the bit at position p have value 1?");
            Console.WriteLine(isBitValue1);
        }
}
