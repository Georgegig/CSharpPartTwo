using System;

class SayHello
{
    static void Main()
    {
        string name = AskForName();

        Console.WriteLine("Hello,{0}",name);
    }
    static string AskForName()
    {
        Console.WriteLine("Please input your name:");
        string name = Console.ReadLine();
        return name;
    }

}

