using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int integerNumber = int.Parse(Console.ReadLine());               
                Console.WriteLine( Math.Sqrt(integerNumber));
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number !"); ;
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
           
        }
    }
}
