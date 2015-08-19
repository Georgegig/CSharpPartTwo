using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var dict = new Dictionary<string, int>();

            foreach (Match word in Regex.Matches(str, @"\w+"))
                dict[word.Value] = dict.ContainsKey(word.Value) ? dict[word.Value] + 1 : 1;

            foreach (var pair in dict)
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
