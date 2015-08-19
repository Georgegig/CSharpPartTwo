using System;
    class Reversed
    {
        static void Main()
        {
            Console.WriteLine("Please input an integer :");
            string input = Console.ReadLine();
            string result = WhySoSerious(input);
            Console.WriteLine(result);
        }

        static string WhySoSerious(string input)
        {
            char[] option = (char[])input.ToCharArray();
            char temp = ' ';
            int mid = 0;
            
            if (input.Length%2==0)
            {
                 mid = option.Length / 2;
                 for (int i = 0; i <= mid-1; i++)
                 {
                     if (i==mid-1)
                     {
                         temp = option[mid-1];
                             option[mid-1] = option[mid];
                         option[mid] = temp;
                     }
                     else
                     {
                         temp =option[i];
                     option[i] = option[option.Length-1- i];
                     option[option.Length - 1 - i] = temp;
                     }
                     
                 }
            }
            else
            {
                 mid = option.Length / 2 + 1;
                 for (int i = 0; i < mid; i++)
                 {
                     temp = option[i];
                     option[i] = option[option.Length-1 - i];
                     option[option.Length - 1 - i] = temp;
                 }
            }
            string final = new string(option);
            return final;
        }
    }

