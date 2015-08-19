using System;
class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please input a binary representation of a number: ");
        string binaryNumber = Console.ReadLine();
        SomeMethod(binaryNumber);
    }
    static void SomeMethod(string binaryNumber)
    {
        int charArrayElAsDigit = 0;
        int sum = 0;
        int currentProduct = 1;
        char[] charArray = binaryNumber.ToCharArray();
        Array.Reverse(charArray);
        
        for (int i = 0; i < charArray.Length; i++)
        {
            if (i==0)
            {
                if (charArray[i]=='0')
                {
                    charArrayElAsDigit = 0;
                }
                else if (charArray[i]=='1')
                {
                    charArrayElAsDigit = 1;
                }
                currentProduct= charArrayElAsDigit;
                sum += currentProduct;
            }
            else
	        {
                for (int j = 1; j <= i; j++)
                {
                    currentProduct *= 2;
                }
                if (charArray[i] == '0')
                {
                    charArrayElAsDigit = 0;
                }
                else if (charArray[i] == '1')
                {
                    charArrayElAsDigit = 1;
                }
                sum += charArrayElAsDigit*currentProduct;
	        }
            currentProduct = 1;
        }
       
        Console.WriteLine("Your number is {0}",sum);
    }
}

