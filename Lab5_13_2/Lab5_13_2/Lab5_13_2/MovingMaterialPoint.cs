using System;
namespace Lab5_13_2
{
    public abstract class MovingMaterialPoint
    {
        public abstract double findX(double t);
        public abstract double findY(double t);
        public static double findDistance(double t, MovingMaterialPoint point, MovingMaterialPoint other)
        {
            return Math.Sqrt(Math.Pow(point.findX(t) - other.findX(t), 2) + Math.Pow(point.findY(t) - other.findY(t), 2));
        }
    }
}
