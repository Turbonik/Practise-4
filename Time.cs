using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practise_4
{
    public class Time
    {
        public int hour;
        public int minute;
        public int second;
        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                if (value >= 0 & value < 60)
                {
                    second = value;
                }
                else
                {
                    second = 0;
                }
            }
        }

        public int Minutes
        {
            get
            {
                return minute;
            }

            set
            {
                if (value >= 0 & value < 60)
                {
                    minute = value;
                }
                else
                {
                    minute = 0;
                }
            }
        }

        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                if (value >= 0 & value < 24)
                {
                    hour = value;
                }
                else
                {
                    hour = 0;
                }
            }
        }
        public Time(int hour, int minute, int seconds)
        {
            Hour = hour;
            Minutes = minute;
            Second = seconds;
        }

        public string Show_time() {

            return $"{this.hour}:{this.minute}:{this.second}";
        }

        public int Count_time()
        {
            return this.hour * 3600 + this.minute * 60 + this.second;
        }

    }
}