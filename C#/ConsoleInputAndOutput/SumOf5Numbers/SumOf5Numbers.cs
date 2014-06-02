using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            string[] userINput = Console.ReadLine().Split(' ');
            double a = double.Parse(userINput[0]);
            double b = double.Parse(userINput[1]);
            double c = double.Parse(userINput[2]);
            double d = double.Parse(userINput[3]);
            double e = double.Parse(userINput[4]);

            double sumOfAll = a + b + c + d + e;
            Console.WriteLine(sumOfAll);
        }
    }

