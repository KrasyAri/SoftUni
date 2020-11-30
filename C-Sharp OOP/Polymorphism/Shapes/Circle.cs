using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * (radius * radius);
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2* Math.PI * radius;
            return perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
