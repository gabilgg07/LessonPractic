using System;
namespace Tasks.Classes
{
    public abstract class Quadrangular
    {
        public Quadrangular(double a, double b, double c, double d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }

        double a;
        double b;
        double c;
        double d;

        protected double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Can not be zero or negative");

                this.a = value;
            }
        }
        protected double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Can not be zero or negative");

                this.b = value;
            }
        }
        protected double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Can not be zero or negative");

                this.c = value;
            }
        }
        protected double D
        {
            get
            {
                return d;
            }
            set
            {
                if (value <= 0)
                    throw new Exception("Can not be zero or negative");

                this.d = value;
            }
        }

        public double GetPerimeter(double a, double b, double c, double d)
        {
            double p = a + b + c + d;
            return p;
        }

        public abstract double GetArea();
    }
}
