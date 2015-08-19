using System;

class CompareCharArrays
{
    static void Main()
    {
        string[] firstWord = new string[2];
        string[] secondWord = new string[2];
        bool equal = false;
        Console.WriteLine("enter two words");
        for (int i = 0; i < firstWord.Length; i++)
        {
            firstWord[i] = Console.ReadLine();
        }
        Console.WriteLine("enter two words");
        for (int i = 0; i < secondWord.Length; i++)
        {
            secondWord[i] = Console.ReadLine();
        }
        for (int i = 0; i < firstWord.Length; i++)
        {
            for (int j = 0; j < firstWord[i].Length; j++)
            {
                string firstWoord = firstWord[i];
                char charOne = firstWoord[j];
                string secondWoord = secondWord[i];
                char charTwo = secondWoord[j];
                if (charOne==charTwo)
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                    break;
                }
            }
            if (equal)
            {
                Console.WriteLine("The {0} words are equal.",i);
            }
            else
            {
                Console.WriteLine("The {0} words are not equal",i);
            }
        }
    }
}

