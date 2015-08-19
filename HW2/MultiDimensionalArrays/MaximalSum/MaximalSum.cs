using System;

class MaximalSum
{
    static void Main()
    {

        int[,] matrix = {
  {1, 1, 1, 0, 0, 0},
  {1, 1, 1, 2, 0, 6},
  {1, 1, 1, 0, 0, 18} };
        int maxRow = 0;
        int maxCol = 0;
        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2] + matrix[row, col + 2] + matrix[row + 1, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    maxRow = row;
                    maxCol = col;
                }

            }
        Console.WriteLine("Max sum is {0}", bestSum);
        for (int i = maxRow; i <= maxRow + 2; i++)
        {
            for (int j = maxCol; j <= maxCol + 2; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }

    }
}

