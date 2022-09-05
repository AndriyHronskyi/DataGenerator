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

        private int Year { get; set; }
        private int Month { get; set; }
        private int Day { get; set; }

        public string _month;
        public string _day;
        public RandomDate() 
        {
            Year = rnd1.Next(1999, 2022);
            Month = rnd1.Next(01, 12);
            if (Month == 02)
            {
                Day = rnd1.Next(01, 28);
            }
            else
            {
                Day = rnd1.Next(01, 30);
            }
        }

        public void FormatDate()
        {
            if (Month < 10)
            {
                _month = "0"+Month.ToString();
            }
            else if (Day < 10)
            {
                _day = "0"+Day.ToString();
            }
        }

        public string GetRandomDate()
        {
            return Year.ToString() + _month + _day;
        }
    }
}
