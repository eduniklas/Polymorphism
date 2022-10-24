using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometri C1 = new Circle();
            Geometri R1 = new Rektangle();
            Geometri S1 = new Square();
            Geometri P1 = new Parallellogram();
            Geometri E1 = new Ellips();

            Console.WriteLine("Area på cirkel: " + Math.Round(C1.Area(), 3));
            Console.WriteLine("Area på rektangel: " + Math.Round(R1.Area(), 3));
            Console.WriteLine("Area på fyrkant: " + Math.Round(S1.Area(), 3));
            Console.WriteLine("Area på parallellogram: " + Math.Round(P1.Area(), 3));
            Console.WriteLine("Area på ellips: " + Math.Round(E1.Area(), 3));
        }
    }
}