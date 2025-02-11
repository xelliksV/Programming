using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private String name;
        private String surname;
        private int number;
        private int age;
        public Contact() { }

        public Contact(string name, String surname, int number, int age)
        {
            setName(name);
            setNumber(number);
            setAge(age);
            setSurname(surname);
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
        public String getSurname()
        {
            return surname;
        }
        public void setName(String name)
        {
            if (assertStringContainsOnlyLetters(name))
            {
                this.name = name;
            } else
            {
                MessageBox.Show("Некорректное имя");
            }
        }
        public void setNumber(int number)
        {
            if (Validator.assertOnPositiveValue(number))
            {
                this.number = number;
            }
        }
        public void setAge(int age)
        {
            if (Validator.assertOnPositiveValue(age))
            {
                this.age = age;
            }
        }
        public void setSurname(String surname)
        {
            if (assertStringContainsOnlyLetters(surname))
            {
                this.surname = surname;
            } else
            {
                MessageBox.Show("Некорректное значение фамилии");
            }
        }
        private bool assertStringContainsOnlyLetters(String value)
        {
            String pattern = @"^[a-zA-Z]+$";
            StackTrace trace = new StackTrace(true);
            if (Regex.IsMatch(value, pattern))
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Некорректное значение" + trace.GetFrame(trace.FrameCount - 1).GetMethod().Name);
            }
        }
    }
}
