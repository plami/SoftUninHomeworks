using System;

    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("a = ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int numberB = int.Parse(Console.ReadLine());
            int GCD = numberA % numberB;

            while (GCD != 0)
            {
                numberA = numberB;
                numberB = GCD;
                GCD = numberA % numberB;
            }
            Console.WriteLine(Math.Abs(numberB));
        }
    }

