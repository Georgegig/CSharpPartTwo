using System;

    class LargerThanNeighbours
    {
        static void Main()
        {
            Console.WriteLine("Please input an integer n : ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Input number {0} :", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input a position between 0 and {0}",n-1);
            int k = int.Parse(Console.ReadLine());
            bool result = Bigger(k, numbers);
            Console.WriteLine("The result is : {0}", result);
        }
        static bool Bigger(int n,int[] numbers)
        {
            bool isBigger = false;
            if (n==0)
            {
                if (numbers[n]>numbers[n+1])
                {
                    isBigger = true;
                }
                
            }
            else if (n == numbers.Length - 1)
            {
                if (numbers[n]>numbers[n-1])
                {
                    isBigger = true;    
                }
            }
            else
            {
                if (numbers[n]>numbers[n+1]&& numbers[n]>numbers[n-1])
                {
                    isBigger = true;
                }
            }
            return isBigger;
        }
    }

