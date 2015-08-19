using System;
class SequenceNMatrix
{
    static void Main()
    {
        //initializing the string array
        Console.WriteLine("Please input number of rows:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input number of cols:");
        int cols = int.Parse(Console.ReadLine());
        string[,] symbols = new string[rows, cols];

        //filling the string array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("element[{0},{1}] =",i,j);
                symbols[i, j] = Console.ReadLine();
                Console.WriteLine();
            }
        }

        //intializing maxCounter variable and counter variable
        int maxCounter = 0;
        int counter = 1;
        string currentSymbol = " ";
        //checking over rows

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols-1; j++)
            {
                for (int k = j+1; k < cols; k++)
                {
                    if (symbols[i,j]==symbols[i,k])
                    {
                        counter++;                       
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            currentSymbol = symbols[i, j];
                        }
                    }
                }
                counter = 1;
            }
        }

        //checking over cols

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows - 1; j++)
            {
                for (int k = j + 1; k < rows; k++)
                {
                    if (symbols[j, i] == symbols[k, i])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            currentSymbol = symbols[j, i];
                        }
                    }
                }
                counter = 1;
            }
        }

       //checking over diagonals
        


        Console.WriteLine(maxCounter);
        Console.WriteLine(currentSymbol);

    }
}

