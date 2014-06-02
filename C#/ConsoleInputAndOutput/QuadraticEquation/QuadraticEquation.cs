using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter coefficient a = ");
            double coefficientA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient b = ");
            double coefficientB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient c = ");
            double coefficientC = double.Parse(Console.ReadLine());
            double discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);
            if (discriminant < 0)
            {
                Console.WriteLine("There is no real roots!");
            }
            if (discriminant > 0)
            {
                Console.WriteLine("x1 = {0}", (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA));
                Console.WriteLine("x2 = {0}", (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA));
            }
            if (discriminant == 0)
            {
                Console.WriteLine("x1 = x1 = {0}", -coefficientB / (2 * coefficientA));
            }
        }
    }

