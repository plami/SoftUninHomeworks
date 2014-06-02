using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double numberC = double.Parse(Console.ReadLine());

        if (numberA > numberB)
        {
            if (numberA > numberC)
            {
                Console.WriteLine("The biggest number is: {0}", numberA);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", numberC);
            }
        }
        else if (numberB > numberC)
        {
            Console.WriteLine("The biggest number is: {0}", numberB);
        }
        else
        {
            Console.WriteLine("The biggest numberis: {0}", numberC);
        }
    }
}

       

