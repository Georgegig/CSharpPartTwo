using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            string input = Console.ReadLine();
            char[] randomArray = input.ToCharArray();
            Array.Reverse(randomArray);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < randomArray.Length; i++)
            {
                result.Append(randomArray[i]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
