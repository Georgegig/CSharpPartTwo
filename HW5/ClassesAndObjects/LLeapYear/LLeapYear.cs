using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLeapYear
{
    class LLeapYear
    {
        static bool IsLeapYear(int year)
        {
            bool IsLeap = false;
            if (DateTime.IsLeapYear(year))
            	{
                    IsLeap=true;
		            return IsLeap ;
	            }
            else
	            {
                     IsLeap=false;
                     return IsLeap;
	            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a year:");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = IsLeapYear(year);
            Console.WriteLine("Your result, whether the input year is leap, is : {0}",isLeap);
        }
    }
}
