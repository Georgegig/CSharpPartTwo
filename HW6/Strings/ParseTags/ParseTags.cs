using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter text with <upcase> tags to transform it to Uppercase:");
            string text = Console.ReadLine();
            string result = Regex.Replace(text, "<upcase>(.*?)</upcase>", c => c.Groups[1].Value.ToUpper());
            Console.WriteLine(result);
            
        }
    }
}
