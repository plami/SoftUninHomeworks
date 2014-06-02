using System;

    class StringAndObjects
    {
        static void Main()
        {
            string firstVariable = "Hello";
            string secondVariable = "World";
            object both = firstVariable + " " + secondVariable;
            string casting = (string)both;
            Console.WriteLine(casting);
        }
    }

