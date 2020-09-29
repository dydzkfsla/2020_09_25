using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2020_09_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            DateTime t1 = new DateTime(2017, 11, 15).AddDays(1000);

            DateTime to1 = new DateTime(2020,09,26,13,00,00);
            DateTime to2 = DateTime.Now;

            TimeSpan span = to1 - to2;

            
            Console.WriteLine(to1.ToString("yyyy.MM.dd"));
            Console.WriteLine(to2.ToString("yyyy.MM.dd"));

            DateTime test = DateTime.Now;
            DateTime from = test.AddDays(-(test.Day - 1));
            DateTime to = from.AddMonths(1).AddDays(-1);

            Console.WriteLine((int)span.TotalHours);

            Console.WriteLine(from.ToString("yyyy.MM.dd")+ " ~ "+ to.ToString("yyyy.MM.dd"));

            DateTime from1 = test.AddDays(-(int)test.DayOfWeek);
            DateTime too = from1.AddDays(6);
            Console.WriteLine(from1.ToString("yyyy.MM.dd") + " ~ " + too.ToString("yyyy.MM.dd"));

            
        }
    }
}
