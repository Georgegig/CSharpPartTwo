using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDays
{
    class WorkDays
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Please input a date (month--day--year):");
            string input = Console.ReadLine();
            DateTime inputDate = new DateTime();
            int count = 0;
            DateTime[] preDefinedDates = 
            {   
                new DateTime(2015,03,03),
                new DateTime(2015,12,24),
                new DateTime(2015,05,06),
                new DateTime(2015,06,01),
                new DateTime(2015,09,15)

            };
            if (DateTime.TryParse(input, out inputDate))
            {
                if (now.Date>inputDate.Date)
                {
                    Console.WriteLine("Wrong input. The date is in the past. Please try again.");
                }
                else
                {
                    double workDaysLeft = (inputDate - now).TotalDays;
                    for (int i = 1; i < workDaysLeft; i++)
                    {
                        DateTime temp = now.AddDays(i);                        
                        foreach (var date in preDefinedDates)
                        {
                            if (date.Day==temp.Day && date.Month==temp.Month)
                            {
                                goto ContinueFor;
                            }
                        }
                        if (temp.DayOfWeek==DayOfWeek.Saturday || temp.DayOfWeek==DayOfWeek.Sunday)
                        {
                            continue;
                        }
                        else 
                        {
                            count++;
                            Console.WriteLine(temp);
                        }
                    ContinueFor:
                        continue;
                    }
                    Console.WriteLine("Workdays left: {0}",count);
                }
            }
            else
            {
                Console.WriteLine("Wrong input. Please try again.");
            }
        }
    }
}
