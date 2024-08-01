using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0 = 0;
            int y0 = 0;

            int x1 = 100;
            int y1 = 100;

            int dX = x1 - x0;
            int dY = y1 - y0;
            double distance = Math.Sqrt(dX * dX + dY * dY);
            int numtest = int.Parse(Console.ReadLine());
            int[,] points = new int[10, 2];
            for (int i = 0; i < numtest; i++)
            {
                Console.WriteLine("point " + (i + 1).ToString() + " x: ");
                points[i, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("point " + (i + 1).ToString() + " y: ");
                points[i, 1] = int.Parse(Console.ReadLine());
            }
        }

       

        public void calculate(double[,] points)
        {
            var distanceArray = new double[points.Length, points.Length];

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    distanceArray[i, j] = Distance(points[i, 0], points[i, 1], points[j, 0], points[j, 1]);
                }
                    
            }
                
        }

        public static double Distance(double x1, double y1, double x2, double y2)
        => Math.Sqrt(((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
    }
}
