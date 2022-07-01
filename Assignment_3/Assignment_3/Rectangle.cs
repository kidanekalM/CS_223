using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; } 
        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Height = length;
        }

        public override double calculateArea()
        {
            return Width * Height;
        }

        public override double calculatePerimeter()
        {
            return (Width * 2) + (Height * 2);
        }
    }
}
