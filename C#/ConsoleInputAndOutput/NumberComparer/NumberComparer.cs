using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("a = ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double secondNumber = double.Parse(Console.ReadLine());
            double greaterNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater number is {0}", greaterNumber);
        }
    }

