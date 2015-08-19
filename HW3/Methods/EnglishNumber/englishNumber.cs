using System;

class englishNumber
{
    static void Main()
    {
        Console.WriteLine("please input an integer ");
        int n = int.Parse(Console.ReadLine());
        string result = EnglishWord(n);
        Console.WriteLine(result);
    }
    static string EnglishWord(int number)
    {
        string result = " ";       

        int currentDigit = number % 10;

        switch (currentDigit)
        {
            case 1: result = "one"; break;
            case 2: result = "two"; break;
            case 3: result = "three";break;
            case 4: result = "four";break;
            case 5: result = "five";break;
            case 6: result = "six";break;
            case 7: result = "seven";break; 
            case 8: result = "eight";break; 
            case 9: result = "nine";break;           
        }
        return result;
    }
}

