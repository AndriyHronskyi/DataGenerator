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

        public string _month;
        public string _day;
        public RandomDate() 
        {
            Year = rnd1.Next(1999, 2022);
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
            if (Month < 10 || Day < 10)
            {
                if (Month < 10 && Day < 10)
                {
                    _month = "0" + Month.ToString();
                    _day = "0" + Day.ToString();
                }
                else if(Month < 10)
                {
                    _month = "0" + Month.ToString();
                    _day = Day.ToString();
                }
                else
                {
                    _month = Month.ToString();
                    _day = "0" + Day.ToString();
                }
            }
            else
            {
                _month = Month.ToString();
                _day = Day.ToString();
            }

            return Year.ToString() + _month + _day;
        }
    }
}
