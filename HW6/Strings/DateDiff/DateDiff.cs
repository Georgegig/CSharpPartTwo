using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDiff
{
    class DateDiff
    {
        static void Main(string[] args)
        {
            DateTime dateone = new DateTime(2015,02,12);
            DateTime datetwo = new DateTime(2015,02,18);
            double result = (datetwo - dateone).TotalDays;
            Console.WriteLine(result);
        }
    }
}
