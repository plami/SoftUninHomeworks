using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("a = ");
            double variableA = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double variableB = double.Parse(Console.ReadLine());

            if (variableA > variableB)
            {
                double variableC = variableA + variableB;
                variableA = variableB;
                variableB = variableC - variableA;
                Console.WriteLine("The result after the exchange is: {0} {1}", variableA, variableB);
            }
            else
            {
                Console.WriteLine("The result is: {0} {1}", variableA, variableB);
            }
        }
    }

       