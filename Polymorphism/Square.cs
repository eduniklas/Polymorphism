using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Square : Geometri
    {
        public double Hight { get; set; }
        public Square()
        {
            Hight = 5.3;
        }
        public override double Area()
        {
            double Area = Math.Pow(Hight, 2);
            return Area;
        }
    }
}