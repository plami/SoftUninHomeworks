using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        char a = '\u2660';
        char b = '\u2665';
        char c = '\u2666';
        char d = '\u2663';

        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine(" " + i + d + " " + i + c + " " + i + b + " " + i + a);
            }
            else
            {
                for (int j = i; j < i + 1; j++)
                {
                    switch (i)
                    {
                        case 11:
                            Console.WriteLine(" J" + d + " J" + c + " J" + b + " J" + a);
                            break;
                        case 12:
                            Console.WriteLine(" Q" + d + " Q" + c + " Q" + b + " Q" + a);
                            break;
                        case 13:
                            Console.WriteLine(" K" + d + " K" + c + " K" + b + " K" + a);
                            break;
                        case 14:
                            Console.WriteLine(" A" + d + " A" + c + " A" + b + " A" + a);
                            break;
                    }
                }
            }
        }
        Console.WriteLine();
    }
}

