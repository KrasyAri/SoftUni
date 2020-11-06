using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        
        public double Lenght 
        { 
            get
            {
                return this.length;
            }
            set 
            {
                if (value <0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            } 
        }
        public double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Heigh
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            Lenght = length;
            Width = width;
            Heigh = height;
        }

        public string SurfaceArea ()
        {
            double surfaceArea = (2 * length * height) + (2 * length * width) + (2 * width * height);
            return $"Surface Area - {surfaceArea:f2}";
        }

        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * length * height) + (2 * width * height);
            return $"Lateral Surface Area - {lateralSurfaceArea:f2}";
        }

        public string Volume()
        {
            double volume = length * width * height;
            return $"Volume - {volume:f2}";
        }
    }
}
