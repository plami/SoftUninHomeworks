using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 20)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine("Matrix :");
                Console.WriteLine();

                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < n + i; j++)
                    {
                        Console.Write(" {0} ", j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }

