
using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;

        int count = 1;
        int rows = 4;

        for (int i = 0; i < rows; i++)
        {
            for (int k = 0; k < rows - count - i; k++)
            {
                Console.Write(' ');
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write(copyRight);
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(copyRight);
            }             
            if (i < rows - 1)
                Console.Write(Environment.NewLine);
        }
            Console.WriteLine();
        }
    }