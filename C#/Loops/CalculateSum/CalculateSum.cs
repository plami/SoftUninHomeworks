using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter integer n :");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter integer x :");
        int numberX = int.Parse(Console.ReadLine());
        
        double factorialN = 1;
        double multiX = 1;
        double sum = 1;

        for (int i = 1; i <= numberN; i++)
        {
            factorialN *= i;
            multiX *= numberX;
            sum += factorialN / multiX;
        }
        Console.WriteLine("The sum is : {0:F5}", sum);
    }
}


