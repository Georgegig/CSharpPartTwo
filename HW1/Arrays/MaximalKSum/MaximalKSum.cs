using System;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("You are about to enter two integer numbers. N MUST BE BIGGER THAN K!");
        Console.WriteLine("Please inpu N ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input K ");
        int k = int.Parse(Console.ReadLine());
        int[] newArray = new int[n];
        int sum = 0;
        int biggestSum = 0;
        int initNumber = 0;
        if (n>k)
        {
            Console.WriteLine("Please input {0} numbers", n);
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < newArray.Length; i++)
            {                
                    if (i+k-1<=newArray.Length-1)
                    {
                        for (int j = 0; j < k; j++)
			            {
                            sum += newArray[i + j];
                            if (biggestSum<sum)
                            {
                                biggestSum = sum;
                                initNumber = i;
                            }
			            }
                        sum = 0;
                    }
                    else
                    {
                        break;
                    }
            }
            for (int i = 0; i <k; i++)
            {
                Console.Write("{0} ",newArray[initNumber+i]);   
            }
            Console.WriteLine();
            Console.WriteLine("Their sum is : {0}",biggestSum);
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
       
    
    }
}

