/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.*/


using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Employee information:");
        string firstName = "Penio";
        string lastName = "Goshev";
        byte age = 55;
        char gender = 'm';
        int idNumber = 1234232;
        long empNumber = 908253809253809;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender (f/m): " + gender);
        Console.WriteLine("Personal ID Number: " + idNumber);
        Console.WriteLine("Unique employee number: " + empNumber);
    }
}