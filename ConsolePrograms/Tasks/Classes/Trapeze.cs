using System;
namespace Tasks.Classes
{
    public class Trapeze : Quadrangular
    {
        double h;

        public Trapeze(double a, double b, double c, double d, double h)
            : base(a, b, c, d)
        {
            this.h = h;
        }

        public override double GetArea()
        {
            double area = (B + D) * h / 2;

            return area;
        }
    }
}
