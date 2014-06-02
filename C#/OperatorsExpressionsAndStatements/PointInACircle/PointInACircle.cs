using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("x =");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y =");
            double y = double.Parse(Console.ReadLine());
            double radius = 2; 

            bool inside = (x * x) + (y * y) <= (radius * radius);
            Console.WriteLine("These coodinates are inside the circle= {0}",inside);
        }
    }

