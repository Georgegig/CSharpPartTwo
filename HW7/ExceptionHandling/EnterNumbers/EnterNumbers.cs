using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            try 
            	{	        
            		Console.WriteLine("Please input the start of the range");
                    int start = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the end of the range");
                    int end = int.Parse(Console.ReadLine());
                    ReadNumber(start,end);
                    readNumber(start, end);
                    
            	}
            catch (FormatException)
            	{
            		
            		throw ;
            	}
        }
        static void ReadNumber(int start, int end)
        {
            Random rNd = new Random();
            
            Console.WriteLine(rNd.Next(start,end+1));
        }
        static void readNumber(int start, int end)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(rnd.Next(start,end+1));
            }
        }
    }
}
