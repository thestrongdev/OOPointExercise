using System;
using System.Collections.Generic;

namespace OOPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            RunPoint();
        }

        static void RunPoint()
        {
            bool keepPlay = true;

            do
            {
                
                Point userPoint = new Point();
                List<double> cooridinates = GetPoints();

                userPoint.x = cooridinates[0];
                userPoint.y = cooridinates[1];
                userPoint.ShowPoint();
         
            } while (keepPlay = ContinuePoint()); ;
        }

        static List<double> GetPoints()
        {

            do
            {
                Console.WriteLine("\nPlease enter numerical cooridinates in the following format: x y";
                string userPoint = Console.ReadLine();

                string[] points = userPoint.Split(" ");

                if (double.TryParse(points[0], out double x) &&
                double.TryParse(points[1], out double y))
                {
                    List<double> coorid = new List<double>();
                    coorid.Add(x);
                    coorid.Add(y);
                    return coorid;
                }
                else
                {
                    Console.WriteLine("\nInvalid entry. Please try again.");
                }
            } while (true);

        }

        static bool ContinuePoint()
        {
            Console.WriteLine("\nWould you like to make another point (y/n)");

            do
            {
                string userChoice = Console.ReadLine();

                if (userChoice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("GOODBYE!");
                    return false;
                }
                else if (userChoice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("that's not a valid input. please enter y or n");
                }

            } while (true);
        }
    }
}
