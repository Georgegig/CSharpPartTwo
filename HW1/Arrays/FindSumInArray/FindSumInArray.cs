using System;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Please input the lenght of the array.");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Please input a desired sum to look for in the array.");
        int sumInput = int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine("Please input {0} integers",n);

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            sum = array[i];
            for (int j = i+1; j < array.Length; j++)
            {
                
                if (sum < sumInput)
                {
                    sum += array[j];
                }
                else if (sum == sumInput)
                {
                    for (int k = i; k < j; k++)
                    {
                        Console.Write("{0} ", array[k]);
                    }
                    break;
                }
                else if (sum>sumInput)
                {
                    break;
                }        
            }
        }

    }
}

