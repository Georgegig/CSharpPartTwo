using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsInCsharp
{
    class StringsInCSharp
    {
        static void Text()
        {
            string input =
                "The string type represents a sequence of zero or more Unicode characters. string is an alias for String in the .NET Framework.Strings are immutable--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this. For example, when you write this code, the compiler actually creates a new string object to hold the new sequence of characters, and that new object is assigned to b. The string \"h\" is then eligible for garbage collection.";

           
            Console.WriteLine(input); 
        }
        static void Main(string[] args)
        {
           Text();
        }
    }
}
