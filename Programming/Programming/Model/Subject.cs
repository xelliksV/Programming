using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Subject
    {
        private String name;
        private String lectorName;
        private int hours;
        public Subject() { }

        public Subject(string name, string lectorName, int hours)
        {
            this.name = name;
            this.lectorName = lectorName;
            setHours(hours);
        }

        public String getName()
        {
            return name;
        }
        public String getlectorName()
        {
            return lectorName;
        }
        public int getHours()
        {
            return hours;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setHours(int hours)
        {
            if (hours < 0)
            {
                MessageBox.Show("Некорректное значение");
            }
            else
            {
                this.hours = hours;
            }
        }
        public void setLectorName(String lectorName)
        {
            this.lectorName = lectorName;
        }
    }
}
