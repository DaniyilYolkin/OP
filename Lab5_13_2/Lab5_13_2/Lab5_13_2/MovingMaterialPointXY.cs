using System;
namespace Lab5_13_2
{
    public class MovingMaterialPointXY: MovingMaterialPoint
    {
        public double X0 { get; set; }
        public double Y0 { get; set; }
        public double A1 { get; set; }
        public double A2 { get; set; }

        public MovingMaterialPointXY(double x, double y, double a1, double a2)
        {
            this.X0 = x;
            this.Y0 = y;
            this.A1 = a1;
            this.A2 = a2;
        }

        public override double findX(double t)
        {
            return this.X0 + this.A1 * Math.Sin(t);
        }

        public override double findY(double t)
        {
            return this.Y0 + this.A2 * Math.Cos(t);
        }
    }
}
