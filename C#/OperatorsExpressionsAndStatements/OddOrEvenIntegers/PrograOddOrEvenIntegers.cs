using System;

    class PrograOddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int n = int.Parse (Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? " Is the number odd?\n false" : " Is the number odd?\n true");
            }
        }
    
