//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? value1 = null;
        double? value2 = null;
        Console.WriteLine("Value of the integer: {0}\nValue of the double: {1}", value1, value2);

        value1 += 2;
        value2 += 3.1;
        Console.WriteLine("\nValues after adding numbers:");
        Console.WriteLine("Value of the integer: {0}\nValue of the double: {1}",value1, value2);
    }
}
