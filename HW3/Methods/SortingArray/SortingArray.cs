using System;

class SortingArray
{
    static void Main()
    {
        int[] numbers = { 1,2,9,8,6,7,5,3,22 };
        int[] array = (int[])numbers.Clone();
        int[] Anumbers = AscendingSort(numbers);
        int[] Dnumbers = DescendingSort(array);

        foreach (var number in Anumbers)
        {
            Console.Write("{0} ",number);
        }
        Console.WriteLine();
        foreach (var number in Dnumbers)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
        Console.WriteLine("Please input an index between 0 and {0}:",numbers.Length-1);
        int k = int.Parse(Console.ReadLine());
        int index = 0;
        int arrayCounter = 0;
        int[] shortArray = new int[numbers.Length-k];
        for (int i = k; i < numbers.Length; i++)
        {
            shortArray[arrayCounter] = numbers[i];
            arrayCounter++;
        } 

        for (int i = 0; i < shortArray.Length-1; i++)
        {
            if (shortArray[i]<shortArray[i+1])
            {
                index = i+1;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("The biggest number starting from position {0} is : {1}",k,shortArray[index]);

    }
    static int[] AscendingSort(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers;
    }
    static int[] DescendingSort(int[] numbers)
    {
        Array.Sort(numbers, (a, b) => b.CompareTo(a));
        return numbers;
    }
}

