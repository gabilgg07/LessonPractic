using System;
namespace Tasks.Classes
{
    public class Rhomb : Quadrangular
    {
        int angle;

        public Rhomb(double a,int angle)
            : base(a, a, a, a)
        {
            this.angle = angle;
        }

        public override double GetArea()
        {
            double area = Math.Pow(this.A, 2) * Math.Sin(Math.PI*angle/180);

            return area;
        }
    }
}
