using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string withQuotation = "The \"use\" of quotations causes difficulies.";
            Console.WriteLine(withQuotation);
            string withoutQuotation = @"The ""use"" of quotations causes difficulies.";
            Console.WriteLine(withoutQuotation);
        }
    }