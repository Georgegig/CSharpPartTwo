using System;

class HexadecimalToDecimal
{
    static void Main()
    {

        Console.WriteLine("Please input a hexadecimal number :");
        string hexValue = Console.ReadLine();
        int decValue = Convert.ToInt32(hexValue, 16);
        Console.WriteLine("Your number represented as a decimal value is : {0}", decValue);
    }
}

