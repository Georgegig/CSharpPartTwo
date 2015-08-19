using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepresentShort
{
    class RepresentShort
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a short integer number: ");
            short n;
            short.TryParse(Console.ReadLine(), out n);
            Console.Write("The binary representation of the number is: ");
            Console.WriteLine(Convert.ToString(n, 2));
        }
    }
}
