using System;

    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Enter width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of the rectangle:");
            int height = int.Parse(Console.ReadLine());
            double perimeter = (2 * width) + (2 * height);
            Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
            double area = width * height;
            Console.WriteLine("The area of the rectangle is: {0}", area);
        }
    }

