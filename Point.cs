using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOPoint
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public void ShowPoint()
        {
            Console.WriteLine($"You have created a point object ({x}, {y}). It has a distance of {CalculateDistance(x, y)}");
        }

        public double CalculateDistance(double x, double y) //calculate distance of a point from origin 0
        {
            double distance = (x * x) + (y * y);
            return Math.Sqrt(distance);
        }

        public Point CalculateMidPoint(Point anotherPoint)
        {
            //add both x cooridinates and divide by two
            //add both y cooridinates and divide by two

            Point midpoint = new Point();

            midpoint.x = (this.x + anotherPoint.x) / 2;
            midpoint.y = (this.y + anotherPoint.y) / 2;

            return midpoint;
        }

    }

 


}
