using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter side a:");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b:");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height h:");
            double heightH = double.Parse(Console.ReadLine());

            double area = ((sideA + sideB) / 2) * heightH;
            Console.WriteLine("The area of the trapezoid is:{0}", area);
        }
    }

