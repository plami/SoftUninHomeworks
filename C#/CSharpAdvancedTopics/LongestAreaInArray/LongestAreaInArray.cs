using System;

class LongestAreaInArray
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        string[] elements = new string[arrayLenght];
 
        for (int i = 0; i < elements.Length; i++)
        {
            string arrayElement = Console.ReadLine();
            elements[i] = arrayElement;
        }
 
        int startIndex = 0;
        int lenghtCount = 1;
        int currentCount = 1;
 
        for (int i = 0; i < elements.Length - 1; i++) 
        {
            if (elements[i] == elements[i + 1])
            {
                currentCount++;
 
                if (currentCount > lenghtCount)
                {
                    lenghtCount = currentCount;
                    startIndex = (i + 1) - (lenghtCount - 1);
                }
            }
            else
            {
                currentCount = 1;
            }
        }
 
        Console.WriteLine(lenghtCount);
        for (int i = 0; i < lenghtCount; i++)
        {
            Console.WriteLine(elements[startIndex + i]);
        }
    }
}

