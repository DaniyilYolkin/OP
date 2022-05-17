using System;
using System.Collections.Generic;

namespace Lab5_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter t: ");
            double t = Convert.ToDouble(Console.ReadLine());
            List<MovingMaterialPoint> points = GeneratePoints(k, n);
            printPoints(t, points);
            Console.WriteLine("Max Distance Between Points is " + Convert.ToString(FindMaxDistance(t, points)));
        }

        public static List<MovingMaterialPointX> GeneratePointsWithX(int k)
        {
            List<MovingMaterialPointX> pointsX = new List<MovingMaterialPointX>();
            var random = new Random();
            for (int i = 0; i < k; i++)
            {
                pointsX.Add(new MovingMaterialPointX(random.NextDouble() * 101 + 1, random.NextDouble() * 101 + 1));
            }
            return pointsX;
        }

        public static List<MovingMaterialPointXY> GeneratePointsWithXAndY(int n)
        {
            List<MovingMaterialPointXY> pointsXY = new List<MovingMaterialPointXY>();
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                pointsXY.Add(new MovingMaterialPointXY(random.NextDouble() * 101 + 1, random.NextDouble() * 101 + 1, random.NextDouble() * 101 + 1, random.NextDouble() * 101 + 1));
            }
            return pointsXY;
        }

        public static List<MovingMaterialPoint> GeneratePoints(int k, int n)
        {
            List<MovingMaterialPoint> points = new List<MovingMaterialPoint>();
            points.AddRange(GeneratePointsWithX(k));
            points.AddRange(GeneratePointsWithXAndY(n));
            return points;
        }

        public static void printPoints(double t, List<MovingMaterialPoint> points)
        {
            Console.WriteLine("Material Points");
            foreach(var point in points)
            {
                Console.WriteLine(string.Format("{0};{1}", point.findX(t), point.findY(t)));
            }
        }

        public static double FindMaxDistance(double t, List<MovingMaterialPoint> points)
        {
            double maxDistance = double.MinValue;
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i; j < points.Count; j++)
                {
                    double distance = MovingMaterialPoint.findDistance(t, points[i], points[j]);
                    if (maxDistance < distance)
                    {
                        maxDistance = distance;
                    }
                }
            }
            return maxDistance;
        }
    }
}
