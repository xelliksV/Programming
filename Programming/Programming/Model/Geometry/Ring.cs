using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class Ring
    {
        private Point2D center;
        private double outerRadius;
        private double innerRadius;

        public void setOuterRadius(double outerRadius)
        {
            if (Validator.assertOnPositiveValue(outerRadius) && outerRadius > innerRadius)
            {
                this.outerRadius = outerRadius;
            }
        }
        public void setInnerRadius(double innerRadius)
        {
            if (Validator.assertOnPositiveValue(innerRadius) && innerRadius < outerRadius)
            {
                this.innerRadius = innerRadius;
            }
        }
        public Point2D getCenter()
        {
            return center;
        }
        public double getOuterRadius()
        {
            return outerRadius;
        }
        public double getInnerRadius()
        {
            return innerRadius;
        }
        public double area()
        {
            return Math.PI * Math.Pow(outerRadius, 2) - Math.PI * Math.Pow(innerRadius, 2);
        }
    }
}
