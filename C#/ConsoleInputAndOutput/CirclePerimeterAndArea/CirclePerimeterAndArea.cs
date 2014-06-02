using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter radius r of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the circle is: {0:F2}", Math.PI * 2 *radius);
            Console.WriteLine("The area of the cricle is: {0:F2}", Math.PI * radius * radius);
        }
    }

