using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBracket
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string with brackets:");
            string input = Console.ReadLine();
            int countOpening = 0;
            int countClosing = 0;
            int indexed = 0;


            while (input.IndexOf('(',indexed) !=-1)
            {
                countOpening++;
                indexed = input.IndexOf('(',indexed)+1;
            }
            indexed = 0;
            while (input.IndexOf(')',indexed) !=-1)
            {
                countClosing++;
                indexed = input.IndexOf(')',indexed)+1;
            }
            if (countClosing==countOpening)
            {
                Console.WriteLine("Correct input");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
