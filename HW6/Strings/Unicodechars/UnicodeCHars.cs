using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicodechars
{
    class UnicodeCHars
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string str = Console.ReadLine();
            foreach (var ch in str)
            {
                list.Add(ch + '\0');
            }
            foreach (var item in list)
            {
                string result = string.Format("\\u{0:X4}", item);
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}
