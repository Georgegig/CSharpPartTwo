using System;



class SortByStringLength
{
    static void Main()
    {

        string[] array = { "ASD","asdasdasdasd", "Berbatov", "DDASS", "DD8-)" };

        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}

