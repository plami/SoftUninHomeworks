﻿using System;

    class PrintLongSequence
    {
        static void Main()
        {
            Console.BufferHeight = 1001;
            for (int i = 2; i < 1001; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("-" + i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

