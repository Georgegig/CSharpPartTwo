using System;

class MaximalNcreasingSequence
{
    static void Main()
    {
        int[] numbers = new int[10];
        int count = 1;
        int lastCounted = 0;
        int initNumber = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }



        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] + 1 == numbers[i + 1] && i != numbers.Length - 1)
            {
                count++;
            }
            else if (numbers[i] + 1 == numbers[i+1] && i == numbers.Length - 1)
            {
                if (count > lastCounted)
                {
                    initNumber = numbers[i] - count + 1;
                    lastCounted = count;
                }
            }
            else if (numbers[i]+1 != numbers[i+1] && i == numbers.Length -1)
            {
                if (count > lastCounted)
                {
                    initNumber = numbers[i] - count + 1;
                    lastCounted = count;
                }
                count = 1;
            }
            else
            {
                if (count > lastCounted)
                {
                    initNumber = numbers[i] - count + 1;
                    lastCounted = count;
                }
                count = 1;

            }
        }
        for (int i = 0; i < lastCounted; i++)
        {
            Console.Write("{0} ", initNumber + i);
        }
        Console.WriteLine();
    }
}

