using System;
namespace Lab5_13_2
{
    public class MovingMaterialPointX: MovingMaterialPoint
    {
        public double X0 { get; set; }
        public double A1 { get; set; }
        public MovingMaterialPointX(double x, double a)
        {
            this.X0 = x;
            this.A1 = a;
        }
        public override double findX(double t)
        {
            return this.X0 + this.A1 * Math.Sin(t);
        }
        public override double findY(double t)
        {
            return 0;
        }
    }
}
