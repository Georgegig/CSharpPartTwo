using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same
{
    class Same
    {
        static void Main()
        {
            Console.WriteLine("Please input an integer n : ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Input number {0} :", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            int result = Bigger(numbers);
            Console.WriteLine("The result is : {0}", result);
        }
        static int Bigger(int[] numbers)
        {
            int result = 0;
            bool isBigger = false;
            for (int i = 0; i < numbers.Length;i++ )
            {
                if (i == 0)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        result = i;
                        isBigger = true;
                        break;

                    }

                }
                else if (i == numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        result = i;
                        isBigger = true;
                        break;
                    }
                }
                else
                {
                    if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                    {
                        result = i;
                        isBigger = true;
                        break;
                    }
                }
            }
            if (isBigger)
            {
                return result;    
            }
            else
            {
                return -1;
            }
            
        }
    }
}
