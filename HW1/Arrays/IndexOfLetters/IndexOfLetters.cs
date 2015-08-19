using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' 
                          ,'p','q','r','s','t','u','v','w','x','y','z'};

        Console.WriteLine("Please input a word");
        string word = Console.ReadLine();
        foreach (var character in word)
        {
            for (int i =0;i<alphabet.Length;i++)
            {
                if (character==alphabet[i])
                {
                    Console.Write("{0} ",i);
                }
            }
        }
        Console.WriteLine();
    }
}

