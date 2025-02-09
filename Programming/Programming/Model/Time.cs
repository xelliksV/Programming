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
            if (hour >= 0 && hour <= 23)
            {
                this.hour = hour;
            } else
            {
                MessageBox.Show("Некорректное значение");
            }
        }
        public void setMinute(int minute)
        {
            if (minute >= 0 && minute <= 60)
            {
                this.minute = minute;
            } else
            {
                MessageBox.Show("Некорректное значение");
            }
        }
        public void setSecond(int second)
        {
            if(second >= 0 && second <= 60)
            {
                this.second = second; 
            }
            else
            {
                MessageBox.Show("Некорректное значение");
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
