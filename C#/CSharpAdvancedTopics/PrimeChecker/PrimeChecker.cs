using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
        bool prime = IsPrime(inputNumber);
        Console.WriteLine(prime);

    }
    public static bool IsPrime(BigInteger candidate)
    {
        // Test whether the parameter is a prime number.
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Note:
        // ... This version was changed to test the square.
        // ... Original version tested against the square root.
        // ... Also we exclude 1 at the end.
        for (int i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
            {
                return false;
            }
        }
        return candidate != 1;
    }
}

  