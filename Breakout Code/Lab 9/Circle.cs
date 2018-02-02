using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Circle
    {
        private double radius;
        private const double PI = Math.PI;

        public Circle(double r)
        {
            radius = r;
        }

        public double GetCircumference()
        {
            double circum = 2 * PI * radius;

            return circum;
        }

        public string FormatCircumference()
        {
            double c = GetCircumference();
            c= Math.Round(c, 2);
            return c.ToString();
        }

    }
}
