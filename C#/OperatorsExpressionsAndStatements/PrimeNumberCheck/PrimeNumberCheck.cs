using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter positive number n between 2 and 100:");
            int numbern = int.Parse(Console.ReadLine());
            while (numbern < 2 || numbern > 100)
            {
                Console.WriteLine("false\nEnter another number:");
                numbern = int.Parse(Console.ReadLine());
            }
            bool isPrime = true;
            int divider = 1;
            int maxDivider = (int)Math.Sqrt(numbern);
            while (divider <= maxDivider)
            {
                if (numbern % divider == 0 && divider > 1)
                {
                    isPrime = false;
                }
                divider++;
            }
            Console.WriteLine("Is your number prime?\n{0}",isPrime);
        }
    }
