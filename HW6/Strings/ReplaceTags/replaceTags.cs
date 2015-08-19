using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class replaceTags
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var strBuilder = new StringBuilder(input);
            strBuilder.Replace("<a href=\"", "[URL=");
            strBuilder.Replace("</a>", "[/URL]");
            strBuilder.Replace("\">", "]");
            Console.WriteLine(strBuilder.ToString());
        }
    }
}
