using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        readonly public double PI = 3.14;

        public override double calculateArea()
        {
            return PI * Radius * Radius;
        }

        public override double calculatePerimeter()
        {
            return PI * 2 * Radius;
        }
    }
}
