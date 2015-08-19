using System;

class GetLargestNumber
{
    static void Main()
    {
        int result = 0;
        result = GetIntegers();
        Console.WriteLine("Biggest number is {0}",result);

    }
    static int GetIntegers() 
    {
        int biggestNumber = 0;
        int counter = 0;
        Console.WriteLine("Please input three integers:");
       int[] numbers = new int[3];
        foreach (var number in numbers)
	{
		 Console.Write("number{0} = ", counter);
            numbers[counter] = int.Parse(Console.ReadLine());
            counter++;
	}
        for (int i = 0; i < 2; i++)
        {
            if (numbers[i]<=numbers[i+1])
            {
                biggestNumber = numbers[i + 1];
            }
        }
        return biggestNumber;
    }
}

