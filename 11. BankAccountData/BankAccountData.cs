/*A bank account has a holder name (first name, middle name and last name),
available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account
using the appropriate data types and descriptive names.*/

using System;

class BankAccountData
{
    static void Main()
    {
        string fName = "Pesho";
        string mName = "Goshov";
        string lName = "Toshov";
        string holderName = fName + " " + mName + " " + lName;
        int bankBalance = 120240;
        char dollar = '$';
        string bankName = "MRA Bank";
        string IBAN = "BGN982304835798";
        long card1 = 3490394085034327;
        long card2 = 3805385094348765;
        long card3 = 3594030950302146;

        Console.WriteLine("Bank account owner: " + holderName);
        Console.WriteLine("Money balance in the bank: " + bankBalance + dollar);
        Console.WriteLine("Bank name: " + bankName);
        Console.WriteLine("IBAN: " + IBAN);
        Console.WriteLine("First card number: " + card1);
        Console.WriteLine("Second card number: " + card2);
        Console.WriteLine("Third card number: " + card3);

    }
}