//Write a program that prints an isosceles triangle of 9 copyright symbols ©

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copyright = '©';
        string space = " ";
        Console.WriteLine(space + space + space + copyright + space + space + space);
        Console.WriteLine(space + space + space + space + space + space + space);
        Console.WriteLine(space + space + copyright + space + copyright + space + space);
        Console.WriteLine(space + space + space + space + space + space + space);
        Console.WriteLine(space + copyright + space + space + space + copyright + space);
        Console.WriteLine(space + space + space + space + space + space + space);
        Console.WriteLine(copyright + space + copyright + space + copyright + space + copyright);
        
    }
}