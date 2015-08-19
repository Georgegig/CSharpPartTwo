using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a decimal number :");
        int decValue = int.Parse(Console.ReadLine());
        string hexValue = decValue.ToString("X");
        Console.WriteLine("Your number represented as a hexadecimal value is : {0}", hexValue);
    }
}

