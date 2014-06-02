using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            int variableA = 5;
            int variableB = 10;
            Console.WriteLine("Variables before exchange are:\n a = {0};\n b = {1}", variableA, variableB);

            int variableC = variableA + variableB;
            variableB = variableC - 10;
            variableA = variableC - 5;
            Console.WriteLine("Variables after exchange are:\n a = {0};\n b = {1}", variableA, variableB);
        }
    }

