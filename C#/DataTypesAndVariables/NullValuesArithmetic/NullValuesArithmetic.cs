using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? variableA = null;
            double? variableB = null;
            Console.WriteLine(" This is the integer with Null value -> {0}\n This is the double variable with Null value -> {1}\n", variableA, variableB);

            variableA += 7;
            variableB += 10;
            Console.WriteLine(" This is the sum of the integer with Null value and 7 -> {0}\n This is the sum of the double variable with Null value and 10 -> {0}\n",variableA,variableB);
            Console.WriteLine(variableB);
        }
    }

