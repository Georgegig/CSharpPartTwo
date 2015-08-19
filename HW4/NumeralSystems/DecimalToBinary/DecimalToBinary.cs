using System;

    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Please input an integer number:");
            int n = int.Parse(Console.ReadLine());
            string example = DecimalToBinary(n);
            Console.WriteLine(example);

        }
        static string DecimalToBinary(int number)
        {
            int result = number;
            int remainder = 0;
            string resultAsString="";
            while (result != 0)
            {
                remainder = result % 2;
                resultAsString += remainder;
                result /= 2;
            }
            char[] charArray = resultAsString.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
    }

