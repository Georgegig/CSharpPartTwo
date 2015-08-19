using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(randomNumber.Next(100,201));
            }
        }
    }
}
