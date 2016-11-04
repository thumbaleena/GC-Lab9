using System;

namespace LabNumber9
{
    internal class Circle
    {
        private readonly double pi = Math.PI;
        public double radius;

        public Circle(double radius) //constructor
        {
            this.radius = radius;
        }

        public double getCircumference
        {
            get { return 2*radius*pi; }
        }

        public double getArea
        {
            get { return pi*(radius*radius); }
        }

        public string getFormattedCircumference()
        {
            return Math.Round(getCircumference, 2).ToString();
        }

        public string getFormattedArea()
        {
            return Math.Round(getArea, 2).ToString();
        }
    }
}