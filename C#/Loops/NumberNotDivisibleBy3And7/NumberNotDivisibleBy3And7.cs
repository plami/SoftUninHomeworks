using System;

class NumberNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter positive integer n : ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 && n > 10)
        {
            Console.Write("Not valid number!");
        }
        else
        {
            Console.WriteLine("The numbers, which are not divisible by 3 and 7 are: ");
        }
       
        for (int i = 1; i <= n; i++)
        {
            if ((i % 7 == 0) || (i % 3 == 0))
            {
                continue;
            }
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

