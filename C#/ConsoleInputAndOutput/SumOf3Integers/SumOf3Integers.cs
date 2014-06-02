using System;

class SumOf3Integers
{
    static void Main()
    {
        Console.WriteLine("Enter integer a:");
        double integerA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer b:");
        double integerB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer c:");
        double integerC = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the three integers = {0}", integerA + integerB + integerC);
    }
}


