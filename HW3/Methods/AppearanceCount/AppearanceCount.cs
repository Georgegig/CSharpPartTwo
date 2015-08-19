using System;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Please input an integer n : ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Input number {0} :",i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

       Console.WriteLine(Counter(numbers));

    }
    static int Counter(int[] numbers)
    {
        int maxCounted = 1;
        int counter = 1;
        for (int i = 0; i < numbers.Length-1; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i]==numbers[j])
                {
                    counter++;    
                }
                if (counter>maxCounted)
                {
                    maxCounted = counter;
                }                
            }
            counter = 1;
        }
        return maxCounted;
    }

}

