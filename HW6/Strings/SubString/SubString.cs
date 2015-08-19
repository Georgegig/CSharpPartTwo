using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString
{
    class SubString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Please input a substring");
            string subStr = Console.ReadLine();
            int count = 0;

            for (int i = 0; i <= input.Length-subStr.Length; i++)
            {
                string currentSub = input.Substring(i, subStr.Length);
                if (currentSub==subStr)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Number of times the specified substring contains in the current input : {0}",count);

        }
    }
}
