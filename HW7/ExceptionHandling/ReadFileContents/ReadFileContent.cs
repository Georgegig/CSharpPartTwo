using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReadFileContents
{
    class ReadFileContent
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            ReadFile(path);
        }
        static void ReadFile(string path)
        {
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Argument exception");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("FileNotFoundException");
            }

        }
    }
}
