/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b
because of the nature of the floating-point arithmetic.
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        Console.WriteLine("Write a variable of type double for a value of \"a\":");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write a variable of type double for a value of \"b\":");
        double b = Convert.ToDouble(Console.ReadLine());
        double result = Math.Abs(a - b);
        if (result < eps)
        {
            Console.WriteLine("\"a\" and \"b\" are equal");
        }
        else
        {
            Console.WriteLine("\"a\" and \"b\" are not equal");
        }
    }
}
