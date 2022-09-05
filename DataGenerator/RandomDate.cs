using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataGenerator
{
    public class RandomDate
    {
        private Random rnd1 = new Random();
        private Random rnd2 = new Random();
        private Random rnd3 = new Random();
        private int Year { get; set; }
        private int Month { get; set; }
        private int Day { get; set; }
        public RandomDate() 
        {
            int Date = new DateTime().Year;
            Year = rnd1.Next(1999, Date);
            Month = rnd2.Next(01, 12);
            if (Month == 02)
            {
                Day = rnd3.Next(01, 28);
            }
            else
            {
                Day = rnd3.Next(01, 30);
            }
        }

        public string GetRandomDate()
        {
            return Year.ToString() + Month.ToString() + Day.ToString();
        }
    }
}
