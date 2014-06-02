using System;

class BeerTime
{
    static void Main()
    {
        DateTime timeBeer = new DateTime();
        Console.Write("Enter time: ");
        bool isValid = DateTime.TryParse(Console.ReadLine(), out timeBeer);
        if (isValid)
        {
            Console.WriteLine("Is it beer time?");
            Console.WriteLine(timeBeer.ToShortTimeString());
            TimeSpan daytime = timeBeer.TimeOfDay;
            TimeSpan endBeertime = new TimeSpan(3, 00, 00);
            TimeSpan startBeertime = new TimeSpan(13, 00, 00);

            if ((daytime < endBeertime) || (daytime >= startBeertime))
            {
                Console.WriteLine("IT IS BEER TIMEEEEEEEEEEEE!");
            }
            else
            {
                Console.WriteLine("NON-BEER TIME");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}





