using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCount
{
    class LCount
    {
        static void Main(string[] args)

        {

            string str = Console.ReadLine();

            int[] values = new int['z' - 'a' + 1];

            foreach (char c in str.ToLower())
                if ('a' <= c && c <= 'z') values[c - 'a']++;

            for (int i = 0; i < values.Length; i++)
                if (values[i] != 0) Console.WriteLine("{0}: {1}", (char)(i + 'a'), values[i]);
        }
    }
}
