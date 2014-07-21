using System;

    class CalculateN_DevidedToK__OneLoop
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (n <= 1 || k > n || k < 1 || n > 100 || k > 100)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                int result = 1;
                for (int i = n; i > k; i--)
                {
                    result *= i;
                }

                Console.WriteLine("The result is : " + result);
            }
            Console.WriteLine();
        }
    }
