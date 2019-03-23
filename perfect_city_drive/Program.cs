using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_city_drive
{
    class Program
    {
        static void Main()
        {
            //method below passes two tests for returning the shortest route from departure to destination
        }

        double perfectCity(double[] departure, double[] destination)
        {

            double result = 0;

            int departureXRight = (int)Math.Ceiling(departure[0]);
            //Console.WriteLine(departureXRight);

            int departureXLeft = (int)Math.Round(departure[0]);

            int destinationXRight = (int)Math.Ceiling(destination[0]);

            int departureYDown = (int)Math.Round(departure[0]);

            int departureYUp = (int)Math.Ceiling(departure[0]);

            double yDistance = destination[1] - departure[1];

            if (destinationXRight == destination[0])
            {

                if (destination[0] - departure[0] > (departure[0] - departureXLeft) + (destination[0] - departureXLeft))
                {

                    result = (departure[0] - departureXLeft) + (destination[0] - departureXLeft) + yDistance;
                    return result;
                }
                else
                {
                    Console.WriteLine("yes");
                    result = destination[0] - departure[0] + yDistance;
                    return result;
                }

            }
            else
            {

                if ((departureXRight - departure[0]) + (destinationXRight - destination[0]) > departure[0] - departureXLeft + destination[0])
                {
                    result = (departure[0] - departureXLeft + destination[0]) + yDistance;
                    return result;
                }
                else
                {
                    result = ((departureXRight - departure[0]) + (destinationXRight - destination[0])) + yDistance;
                    return result;
                }
            }



            return result;

            //
        }

    }
}
