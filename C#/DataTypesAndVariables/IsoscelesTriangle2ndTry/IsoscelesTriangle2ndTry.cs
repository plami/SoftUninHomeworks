using System;
using System.Text;


class IsoscelesTriangle2ndTry
{
    static void Main()
    {
        char copyright = '\u00A9';
        int rows = 5;
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i < rows; i++)
        {
            for (int j = rows - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int ii = 0; ii < i; ii++)
            {
                if (i == 3)
                {
                    Console.Write(copyright + "   " + copyright);
                    break;
                }
                else
                {
                    Console.Write(copyright + " ");
                }
            }
            Console.WriteLine();
        }
    }
}


    