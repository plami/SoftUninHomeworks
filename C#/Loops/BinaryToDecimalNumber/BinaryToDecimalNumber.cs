using System;

    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter your Binary Number : ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            long numberInDecimal = 0;
            
            foreach (char letter in binary)
            {
                int number = int.Parse(letter.ToString());
                numberInDecimal += (int)Math.Pow(2, length - 1) * number;
                length--;
            }

            Console.WriteLine("The conversion from binary to decimal is :" + numberInDecimal);
        }
    }

