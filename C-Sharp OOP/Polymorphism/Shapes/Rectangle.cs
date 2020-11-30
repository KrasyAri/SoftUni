using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea()
        {
            double area = this.height * this.width;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (2 * height) + (2 * width);
            return perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
