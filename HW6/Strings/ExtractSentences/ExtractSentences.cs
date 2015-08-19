using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a sentence to be extracted");
            string word = " " + Console.ReadLine() + " ";
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            List<string> result = new List<string>();
            string[] separatedText = text.Split('.');
            for (int i = 0; i < separatedText.Length; i++)
            {
                if (separatedText[i].IndexOf(word, 0) != -1)
                {
                    result.Add(separatedText[i] + ".");
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Trim());
            }
     
        }
    }
}
