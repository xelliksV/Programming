using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal static class CollisionManager
    {
        public static bool isCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double x = Math.Abs(rectangle1.getCenter().getX() - rectangle2.getCenter().getX());
            double width = (rectangle1.getWidth() + rectangle2.getWidth()) / 2;
            double height = (rectangle1.getHeight() + rectangle2.getHeight()) / 2;
            double y = Math.Abs(rectangle1.getCenter().getY() - rectangle2.getCenter().getY());
            return x < width && y < height;
        }
        public static bool isCollision(Ring ring1, Ring ring2)
        {
            double dX = Math.Pow(Math.Abs(ring1.getCenter().getX() - ring2.getCenter().getX()), 2);
            double dY = Math.Pow(Math.Abs(ring1.getCenter().getY() - ring2.getCenter().getY()), 2);
            double c = Math.Sqrt(dX + dY);
            return c < ring1.getOuterRadius() + ring2.getOuterRadius();
        }
    }
}
