using System;

class MaximalSequence
{
    static void Main()
    {
        int[] numbers = new int[10];
        int count = 1;
        int lastCounted = 0;
        int currentNumber = 0;
        int lastNumber = 0;

        Console.WriteLine("Please input ten numbers");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        lastNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            
            if (lastNumber==numbers[i])
            {
                count++;
            }
            else
            {
                if (lastCounted<count)
                {
                    lastCounted = count;
                    currentNumber = numbers[i - 1];
                }
                count = 1;
                
            }
            lastNumber = numbers[i];
        }
        for (int i = 1; i <= lastCounted; i++)
        {
            Console.Write("{0} ",currentNumber);
        }
        Console.WriteLine();
    }
}

