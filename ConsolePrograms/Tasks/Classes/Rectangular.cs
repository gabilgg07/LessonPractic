using System;
namespace Tasks.Classes
{
    public class Rectangular : Quadrangular
    {
        public Rectangular(double a, double b)
            :base(a,b,a,b)
        {
        }

        public override double GetArea()
        {
            double area = this.A * this.B;
            return area;
        }
    }
}
