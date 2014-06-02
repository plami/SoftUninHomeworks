using System;

class ProDivideBy7And5gram
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        bool isDivided = (number % 7 == 0) && (number % 5 == 0)&& (number!=0);
        Console.WriteLine("The integer is divided b 7 and 5 in the same time without remainder: {0}", isDivided);
    }
}

