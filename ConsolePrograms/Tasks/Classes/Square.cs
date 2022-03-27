using System;
namespace Tasks.Classes
{
    public class Square : Rectangular
    {
        public Square(double a) : base(a, a)
        {
        }

        public override double GetArea()
        {
            double area = Math.Pow(this.A, 2);

            return area;
        }
    }
}
