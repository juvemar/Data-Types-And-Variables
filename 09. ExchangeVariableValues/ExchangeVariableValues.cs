//Declare two integer variables a and b and assign them with 5 and 10 and 
//after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.


using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Integer a = " + a + "\nInteger b = " + b);

        int temporary;//temporary is my bonus variable which helps me to exchange a and b values
        temporary = a;
        a = b;
        b = temporary;
        Console.WriteLine("After the the exchange: \nInteger a = " + a + "\nInteger b = " + b);
    }
}