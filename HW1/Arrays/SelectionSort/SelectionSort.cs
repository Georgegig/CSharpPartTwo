using System;


    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine("Please input N");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int iMin;
            int min;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length-1; i++)
            {

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        min = arr[i];
                        arr[i] = arr[j];
                        arr[j] = min;
                    }
                }               
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }
    }

