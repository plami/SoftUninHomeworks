using System;
using System.Numerics;

class CalculateN_DividedToK_
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        if (n > 1 && k > 1 && n < 100 && k < 100)
        {
            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger result = 0;

            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                factorielK *= j;
            }
            result = factorielN / factorielK;
            Console.WriteLine("The result is : " + result);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}


