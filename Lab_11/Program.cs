using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_11
{
    internal class Program
    {
        
        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        

        public static void Main(string[] args)
        {
            int count = 0;

            Day currentDay = (ref int counter) =>
            {
                if (count == 7)
                    counter = 0;

                DayOfWeek day = () => Console.WriteLine(DaysOfWeek.GetValues(typeof(DaysOfWeek)).GetValue(count));
                day();
                count++;
            };
            currentDay(ref count);
            currentDay(ref count);
            currentDay(ref count);
            currentDay(ref count);
            currentDay(ref count);
            currentDay(ref count);
            currentDay(ref count);
            currentDay(ref count);


        }
        delegate void DayOfWeek();
        delegate void Day(ref int count);
    }
}
