using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter n random number : ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter min integer : ");
        int minInt = int.Parse(Console.ReadLine());
        Console.Write("Enter max integer : ");
        int maxInt = int.Parse(Console.ReadLine());

        if (minInt <= maxInt)
        {
            var numbers = new Random();
            for (int i = 0; i <= numberN; i++)
            {
                Console.Write("{0} ", numbers.Next(minInt, maxInt+1));
            }
        }
        else
        {
            Console.WriteLine("incorrect input");
        }
    }
}

