using System;
using System.Numerics;
    class Factoriel
    {
        static void Main()
        {
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            Factoreil(numbers);
        }
        static void Factoreil(int[] numbers)
        {
            BigInteger result = 1;
            foreach (var number in numbers)
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                Console.WriteLine(result);
                result = 1;
            }
            
        }
    }

