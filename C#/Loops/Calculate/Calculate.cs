using System;
using System.Numerics;

    class Calculate
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (k > 1 && n > 1 && k < 100 && n < 100)
            {
                BigInteger factorielN = 1;
                BigInteger factorielK = 1;
                BigInteger factorielNAndK = 1;
                BigInteger result = 0;

                for (int i = 1; i <= n; i++)
                {
                    factorielN *= i;
                }
                for (int j = 1; j <= k; j++)
                {
                    factorielK *= j;
                }
                for (int z = 1; z <= n - k; z++)
                {
                    factorielNAndK *= z;
                }

                result = factorielN / (factorielK * factorielNAndK);

                Console.WriteLine("n! / (k! * (n-k)!) = " + result);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

        }
    }

