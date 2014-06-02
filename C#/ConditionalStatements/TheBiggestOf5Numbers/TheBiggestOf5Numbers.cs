using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double numberC = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double numberD = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double numberE = double.Parse(Console.ReadLine());

        if (numberA > numberB && numberA > numberC && numberA > numberD && numberA > numberE)
        {
            Console.WriteLine("The biggest number is: {0}", numberA);
        }
        else if (numberB > numberA && numberB > numberC && numberB > numberD && numberB > numberE)
        {
            Console.WriteLine("The biggest number is: {0}", numberB);
        }
        else if (numberC > numberA && numberC > numberB && numberC > numberD && numberC > numberE)
        {
            Console.WriteLine("The biggest number is: {0}", numberC);
        }
        else if (numberD > numberA && numberD > numberB && numberD > numberC && numberD > numberE)
        {
            Console.WriteLine("The biggest number is: {0}", numberD);
        }
        else
        {
            Console.WriteLine("The biggest number is: {0}", numberE);
        }
    }
}



               