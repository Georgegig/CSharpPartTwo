using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input several integer numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] inputAsArray = input.Split(' ');
            int[] inputAsInteger = new int[inputAsArray.Length];
            for (int i = 0; i < inputAsArray.Length; i++)
            {
                inputAsInteger[i] = int.Parse(inputAsArray[i]);
            }
            long sum = 0;
            for (int i = 0; i < inputAsInteger.Length; i++)
            {
                sum += inputAsInteger[i];
            }
            Console.WriteLine(sum);
        }
    }
}
