using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter n numbers : ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = Fib(n);
        Console.WriteLine(result);
    }
    private static BigInteger Fib(int n)
    {
        int firstNum = 0;
        int secondNum = 1;
        int nextNum;

        for (int i = 1; i <= n; i++)
        {
            nextNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = nextNum;

            if (i == n)
            {
                return nextNum;
            }
        }
        return 0;
    }
}



