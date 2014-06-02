using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.Write("Please choose type 1 , 2 or 3 : ");
            int type = int.Parse(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        Console.Write("Please enter an int:");
                        int numberA = int.Parse(Console.ReadLine());
                        Console.Write(numberA + 1); 
                        break;
                    case 2:
                        Console.Write("Please enter a double:");
                        double numberB = double.Parse(Console.ReadLine());
                        Console.WriteLine(numberB + 1); 
                        break;
                    case 3:
                        Console.Write("Please enter a string:");
                        string name = Console.ReadLine();
                        Console.WriteLine(name + "*"); 
                        break;
                    default:
                        Console.WriteLine("Invalid code!"); 
                        break;
                }
            }
        }
