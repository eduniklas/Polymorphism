using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rektangle : Geometri
    {
        public double Length { get; set; }
        public double Widht { get; set; }
        public Rektangle()
        {
            Length = 6;
            Widht = 4.6;
        }
        public override double Area()
        {
            double Area = Widht * Length;
            return Area;
        }
    }
}