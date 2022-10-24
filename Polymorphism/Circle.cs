using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Circle : Geometri
    {
        float Pi = 3.141f;
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 4;
        }
        public override double Area()
        {
            double Area = Radius * Radius * Pi;
            return Area;
        }
    }
}