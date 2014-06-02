using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
           
            int firstDigit = number % 10;

            int numberTwo = number / 10;
            int secondDigit = numberTwo % 10;

            int numberTree = number / 100;
            int thirdDigit = numberTree % 10;

            int numberFour = number / 1000;
            int fourthDigit = numberFour % 10;

            Console.WriteLine("The sum of the four digits is: {0}", (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("The reverse order of the number is: {0}{1}{2}{3}", firstDigit,secondDigit,thirdDigit,fourthDigit);
            Console.WriteLine("The last digit in the first position: {0}{1}{2}{3}",firstDigit,fourthDigit,thirdDigit,secondDigit);
            Console.WriteLine("After exchange of the second and the third digit: {0}{1}{2}{3}", fourthDigit,secondDigit,thirdDigit,firstDigit);
        }
    }

