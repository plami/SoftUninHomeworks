using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Name";
        string middleName = "Middle";
        string lastName = "Last";
        decimal money = 394850.57m;
        string bankName = "Unicredit Bulbank";
        string iban = "BG32 UBBS 7827 5513 6179 03";
        long cardNumber1 = 455656747734323;
        long cardNumber2 = 754554343121221;
        long cardNumber3 = 574836123456789;
        Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
    }
}
