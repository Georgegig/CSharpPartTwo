using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string with length less than or equal to 20 chars :");
            string input = Console.ReadLine();
            if (input.Length<=20)
            {
                if (input.Length==20)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    string filler = new string('*', 20 - input.Length);
                    Console.WriteLine("{0}{1}",filler,input);
                }
               
            }
            else
            {
                Console.WriteLine("Wrong input. Please try again.");
            }
        }
    }
}
