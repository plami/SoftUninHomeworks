using System;

class OddOrEvenProducts
{
    static void Main()
    {
        Console.Write("Enter n integers : ");
        string[] array = Console.ReadLine().Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int index = 0; index < array.Length; index++)
        {
            int number = int.Parse(array[index]);
            if (index % 2 == 0 || index == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd product = {0}", oddProduct);
            Console.WriteLine("even product = {0}", evenProduct);
        }
        Console.WriteLine();
    }
}

