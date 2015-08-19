using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please input an integer number: ");
        int n = int.Parse(Console.ReadLine());
        
        //A
        
        int[,] intArray = new int[n,n];
        int rows = n;
        int cols = n;
        int number=0;
        Console.WriteLine();

        for (int i = 0; i < rows; i++)
        {
            number = i + 1;
            for (int j = 0; j < cols; j++)
            {
                intArray[i, j] = number;
                number += 4;
                Console.Write("{0} ",intArray[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //B

        int[,] intArrayTwo = new int[n, n];
        int counter = 1;
        int adjCounter = 0;


        for (int i = 0; i < cols; i++)
        {
            if (i%2==0)
            {
                for (int j = 0; j < rows; j++)
                {
                    intArrayTwo[j, i] = counter + j;    
                }
            }
            else if(i%2!=0)
            {
                for (int k = rows-1; k >= 0; k--)
                {
                    intArrayTwo[k,i] = counter+adjCounter;
                    adjCounter++;
                }
            }
            adjCounter = 0;
            counter += n;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0} ", intArrayTwo[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //C
        int[,] intArrayThree = new int[n, n];

        int startCount = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                intArrayThree[rows++, cols++] = startCount++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                intArrayThree[cols++, rows++] = startCount++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}  ",intArrayThree[i,j]);
            }
            Console.WriteLine();
        }

        rows = n;
        cols = n;
        Console.WriteLine();

        //D

        int[,] result = new int[n, n];
        int numberToAdd = 1;
        int globalCounter = n;
        int tempValue = -n;
        int sum = -1;

        do
        {
            tempValue = -1 * tempValue / n;
            for (int i = 0; i < globalCounter; i++)
            {
                sum += tempValue;
                result[sum / n, sum % n] = numberToAdd;
                numberToAdd++;
            }
            tempValue *= n;
            globalCounter--;
            for (int i = 0; i < globalCounter; i++)
            {
                sum += tempValue;
                result[sum / n, sum % n] = numberToAdd;
                numberToAdd++;
            }
        } while (globalCounter > 0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}  ", result[i, j]);
            }
            Console.WriteLine();
        }
    }
}

