using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private String name;
        private int number;
        private int age;
        public Contact() { }

        public Contact(string name, int number, int age)
        {
            this.name = name;
            setNumber(number);
            setAge(age);
        }

        public String getName()
        {
            return name;
        }
        public int getNumber()
        {
            return number;
        }
        public int getAge()
        {
            return age;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setNumber(int number)
        {
            if (number > 0)
            {
                this.number = number;
            }
            else
            {
                MessageBox.Show("Некорректное значение");
            }
        }
        public void setAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                MessageBox.Show("Некорректное значение");
            }
        }
    }
}
