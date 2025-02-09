using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double width;
        private double height;
        private String color;

        public Rectangle(double width, double height, string color)
        {
            setWidth(width);
            setHeight(height);
            this.color = color;
        }

        public Rectangle()
        {
        }

        public double getWidth()
        {
            return width;
        }
        public void setWidth(double width)
        {
            if (width > 0)
            {
                this.width = width;
            } else
            {
                MessageBox.Show("Некорректное значение");
            }
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            if (height > 0)
            {
                this.height = height;
            } else
            {
                MessageBox.Show("Некорректное значение");
            }
        }
        public String getColor() 
        {
            return color;
        }
        public void setColor(String color)
        {
            this.color = color;
        }
    }
}
