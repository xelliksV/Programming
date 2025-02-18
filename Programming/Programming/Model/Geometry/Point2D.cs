using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class Point2D
    {
        private double X;
        private double Y;

        public Point2D()
        {
        }
        public Point2D(double x, double y)
        {
            setX(x);
            setY(y);
        }
        private void setX(double x)
        {
            if (Validator.assertValueInRange(x, -100, 500))
            {
                X = x;
            }
        }
        private void setY(double y)
        {
            if (Validator.assertValueInRange(y, -100, 500))
            {
                Y = y;
            }
        }
        public double getX() { return X; }
        public double getY() { return Y; }
        public string toString()
        {
            return $"({X.ToString()};{Y.ToString()})";
        }
    }
}
