using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter n integer numbers : ");
            int n = int.Parse(Console.ReadLine());
            float sum = 0;
            float average = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
 
            for (int i = 1; i <= n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                sum = sum + k;
                max = Math.Max(max, k);
                min = Math.Min(min, k);
            }
            average = sum / n;

            Console.WriteLine("The sum is: "+ sum);
            Console.WriteLine("The average is: {0:F2}", average);
            Console.WriteLine("The maximum number is: " + max);
            Console.WriteLine("The minimum number is: " + min);
        }
    }

