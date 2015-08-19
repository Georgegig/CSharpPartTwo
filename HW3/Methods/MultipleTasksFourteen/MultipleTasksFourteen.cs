using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_SolveMinMaxAverageSumProduct
{
    class SolveMinMaxAverageSumProduct
    {
        static int FindMax(params int[] array)
        {
            int biggestNum = array[0];
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (length > 0)
                {
                    if (array[i] > biggestNum)
                    {
                        biggestNum = array[i];
                    }
                }
                else
                {
                    return 0;
                }

            }
            return biggestNum;
        }

        static int FindMin(params int[] array)
        {
            int smallestNumber = array[0];
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (length > 0)
                {
                    if (array[i] < smallestNumber)
                    {
                        smallestNumber = array[i];

                    }
                }
                else
                {
                    return 0;
                }
            }
            return smallestNumber;
        }

        static double GetAverage(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }
        static int GetSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++) sum += array[i];

            return sum;
        }

        static int FindProduct(params int[] array)
        {
            int product = 1;
            foreach (var number in array)
            {
                product *= number;
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the Array indexes:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Min = {0}", FindMin(array));
            Console.WriteLine("Max = {0}", FindMax(array));
            Console.WriteLine("Sum = {0}", GetSum(array));
            Console.WriteLine("Average = {0}", GetAverage(array));
            Console.WriteLine("Product = {0}", FindProduct(array));
            Console.WriteLine();
        }
    }
}
