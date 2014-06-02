using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("Enter number a: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("Enter number c: ");
            double numberC = double.Parse(Console.ReadLine());

            if (numberA == 0 || numberB == 0 || numberC == 0)
            {
                Console.WriteLine("The result is: 0");
            }
            else if (numberA < 0 && numberB < 0 && numberC < 0)
            {
                Console.WriteLine("The result is: -");
            }
            else if (numberA > 0 && numberB > 0 && numberC > 0)
            {
                Console.WriteLine("The result is: +");
            }
            else if (numberA > 0 && numberB > 0 || numberA > 0 && numberC > 0 || numberB > 0 && numberC > 0)
            {
                Console.WriteLine("The result is: -");
            }
            else if (numberA < 0 && numberB < 0 || numberA < 0 && numberC < 0 || numberB < 0 && numberC < 0)
            {
                Console.WriteLine("The result is: +");
            }
        }
    }
