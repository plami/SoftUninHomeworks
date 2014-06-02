using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("The number is:");
            int number = int.Parse(Console.ReadLine());
            bool thirdDigit7 = ((number / 100) % 10 == 7 || (number / 100) % 10 == -7);
            Console.WriteLine("Is the third digit 7? {0}",thirdDigit7);
        }
    }
