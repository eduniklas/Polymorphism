using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Ellips : Geometri
    {
        float Pi = 3.141f;
        public double AxisA { get; set; }
        public double AxisB { get; set; }
        public Ellips()
        {
            AxisA = 4.5;
            AxisB = 5;
        }
        public override double Area()
        {
            double Area = AxisA * AxisB * Pi;
            return Area;
        }
    }
}