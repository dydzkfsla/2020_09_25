using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace _2020_09_25
{
    class DateTime2
    {
        static void Main()
        {

            System.Timers.Timer timer1 = new System.Timers.Timer();
            
            timer1.Interval = 1000;
            timer1.Elapsed += Timer1_Elapsed;
            
            timer1.Start();

            while (true)
            {

            }
        }

        private static void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);
        }
    }
}
