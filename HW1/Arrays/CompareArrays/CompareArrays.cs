using System;

class CompareArrays
{
    static void Main()
    {
        int[] fisrtArray = new int[5];
        int[] secondArray = new int[5];
        Console.WriteLine("Please input 5 numbers:");
        for (int i = 0; i < fisrtArray.Length; i++)
        {
            fisrtArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please input another 5 numbers:");
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < fisrtArray.Length; i++)
        {
            if (fisrtArray[i]>secondArray[i])
            {
                Console.WriteLine("{0}. The number from the first array is bigger.",i+1);
            }
            else if (fisrtArray[i]<secondArray[i])
            {
                Console.WriteLine("{0}. The number from the second array is bigger.", i+1);
            }
            else
            {
                Console.WriteLine("{0}. The numbers are equal.",i+1);
            }
        }

    }
}
