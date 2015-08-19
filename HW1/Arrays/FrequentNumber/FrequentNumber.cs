using System;


class FrequentNumber
{
    static void Main()
    {
        int[] array = new int[5];
        int count = 1;
        int biggestCount = 1;
        int index = 0;
        Console.WriteLine("Please input five integers");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = i+1; j < array.Length ; j++)
            {
                if (array[i]==array[j])
                {
                    count++;
                }
                if (biggestCount<count)
                {
                    biggestCount = count;
                    index = i;
                }     
            }
            count = 1;
        }
        Console.WriteLine("{0} {1} times",array[index],biggestCount);
    }
}

