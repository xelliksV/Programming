using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Flight
    {
        private String destination;
        private String departure;
        private int duration;

        public Flight()
        {
        }

        public Flight(string destination, string departure, int duration)
        {
            this.destination = destination;
            this.departure = departure;
            setDuration(duration);
        }
        public String getDestination()
        {
            return destination;
        }
        public String getDeparture()
        {
            return departure;
        }
        public int getDuration()
        {
            return duration;
        }
        public void setDestination(String destination)
        {
            this.destination = destination;
        }
        public void setDeparture(String departure)
        {
            this.departure = departure;
        }
        public void setDuration(int duration)
        {
            if (duration > 0)
            {
                this.duration = duration;
            } else
            {
                MessageBox.Show("Некорректное значение");
            }
        }
    }
}
