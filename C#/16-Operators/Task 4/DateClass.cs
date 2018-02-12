using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class DateClass
    {
        public DateTime Date { get; }

        public DateClass()
        {
            Date = DateTime.Now;
        }

        public DateClass(DateTime date)
        {
            Date = date;
        }

        public static DateClass operator -(DateClass d1, DateClass d2)
        {
            TimeSpan timeSpan = d1.Date - d2.Date;
            DateTime date = d1.Date.AddDays(timeSpan.Days);
            return new DateClass(date);
        }

        public static DateClass operator +(DateClass d1, DateClass d2)
        {
            TimeSpan timeSpan = d1.Date - d2.Date;
            DateTime date = d1.Date.AddDays(-timeSpan.Days);
            return new DateClass(date);
        }
    }
}
