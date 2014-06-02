using System;

    class Sort3NumbersWithNestedIFs
    {
        static void Main()
        {
            Console.Write("a = ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double numberC = double.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                if (numberA > numberC)
                {
                    if (numberB > numberC)
                    {
                        Console.WriteLine("The result is: {0} {1} {2}", numberA, numberB, numberC);
                    }
                    else
                    {
                        Console.WriteLine("The result is: {0} {1} {2}", numberA, numberC, numberB);
                    }
                }
                else
                {
                    Console.WriteLine("The result is: {0} {1} {2}", numberC, numberA, numberB);
                }
            }
            else
            {
                if (numberB > numberC)
                {
                    {
                        if (numberA > numberC)
                        {
                            Console.WriteLine("The result is: {0} {1} {2}", numberB, numberA, numberC);
                        }
                        else
                        {
                            Console.WriteLine("The result is: {0} {1} {2}", numberB, numberC, numberA);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The result is: {0} {1} {2}", numberC, numberB, numberA);
                }
            }
        }
    }
