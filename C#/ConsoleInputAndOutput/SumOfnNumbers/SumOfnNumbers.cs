using System;

    class SumOfnNumbers
    {
        static void Main()
        {
            Console.Write("Enter length of the loop: ");
            int length = int.Parse(Console.ReadLine());

            double sum = 0;

            for (double i = 0; i < length; i++)
            {
                Console.Write("Enter number: ",i);
                double number = double.Parse(Console.ReadLine());

                sum += number;
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
