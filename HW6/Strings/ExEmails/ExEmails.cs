using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEmails
{
    class ExEmails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] split = text.Split(' ');
            foreach (var item in split)
            {
                char[] ch = item.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == '@')
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
