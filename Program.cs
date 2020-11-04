using System;

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

                userPoint.x = GetX();
                userPoint.y = GetY();
                userPoint.ShowPoint();
         
            } while (keepPlay = ContinuePoint()); ;
        }

        static double GetX()
        {
            do
            {

                Console.WriteLine("\nPlease enter an x cooridinate (must be an number): ");
                string userX = Console.ReadLine();


                if (double.TryParse(userX, out double x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please try again");
                }


            } while (true);
         }

        static double GetY()
        {
            do
            {

                Console.WriteLine("\nPlease enter an y cooridinate (must be a number): ");
                string userY = Console.ReadLine();

                if (double.TryParse(userY, out double y))
                {
                    return y;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please try again");
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
