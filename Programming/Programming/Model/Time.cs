using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
        }

        public Time(int hour, int minute, int second)
        {
            setHour(hour);
            setMinute(minute);
            setSecond(second);
        }

        public void setHour(int hour)
        {
            if (Validator.assertValueInRange(hour, -1, 24))
            {
                this.hour = hour;
            }
        }
        public void setMinute(int minute)
        {
            if (Validator.assertValueInRange(minute, -1, 61))
            {
                this.minute = minute; 
            } 
        }
        public void setSecond(int second)
        {
            if (Validator.assertValueInRange(second, -1, 61))
            {
                this.second = second;
            }
        }
        public int getHour()
        {
            return hour;
        }
        public int getMinute()
        {
            return minute;
        }
        public int getSecond()
        {
            return second;
        }
    }
}
