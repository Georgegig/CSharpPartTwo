﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace DateInBulgaria
{
    class DateInBulgaria
    {
        static void Main(string[] args)
        {

            string getDate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(getDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6.5);
            Console.WriteLine("{0} {1}", date, date.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
