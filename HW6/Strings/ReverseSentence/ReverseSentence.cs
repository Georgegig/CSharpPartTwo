using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputWords = input.Split(' ');
            string[] reversedInput = new string[inputWords.Length];
            for (int i = 0; i < inputWords.Length; i++)
            {
                reversedInput[i] = inputWords[inputWords.Length - 1 - i];
            }
            StringBuilder inputAsReversedString = new StringBuilder();
            for (int i = 0; i < reversedInput.Length; i++)
            {
                inputAsReversedString.Append(reversedInput[i]);
                inputAsReversedString.Append(' ');
            }
            Console.WriteLine(inputAsReversedString.ToString());
        }
    }
}
