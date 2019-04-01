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

        double perfectCity(double[] departure, double[] destination) {
    
        double result = 0; 
    
        if(departure[1] >= 1)
        {
            double blockDistance = Math.Abs(destination[1] - departure[1]);
        
            int departureRoundUp = (int)Math.Ceiling(departure[0]);
    
            int departureRoundDown = (int)Math.Round(departure[0]);
    
            int destinationRoundUp = (int)Math.Ceiling(destination[0]);
    
            //int destinationRoundDown = (int)Math.Round(destination[0]);
        
            if(Math.Abs(destination[0] - departureRoundUp) + Math.Abs(departureRoundUp - departure[0]) + blockDistance < Math.Abs(destination[0] - departureRoundDown) + (departure[0] + departureRoundDown) + blockDistance)
            {
                result = Math.Abs(destination[0] - departureRoundUp) + (departureRoundUp - departure[0]) + blockDistance;
            }
            else 
            {
                result = Math.Abs(destination[0] - departureRoundDown) + (departure[0] + departureRoundDown) + blockDistance;
            }
        
        }
        else
        {   
           double blockDistance2 = Math.Abs(destination[0] - departure[0]);
        
            int departureRoundUp2 = (int)Math.Ceiling(departure[1]);
    
            int departureRoundDown2 = (int)Math.Round(departure[1]);
    
            int destinationRoundUp2 = (int)Math.Ceiling(destination[1]);
    
            //int destinationRoundDown = (int)Math.Round(destination[0]);
        
            if(Math.Abs(destinationRoundUp2 - destination[1]) + Math.Abs(departureRoundUp2 - departure[1]) + blockDistance2 < Math.Abs(destination[1] - departureRoundDown2) + (departure[1] + departureRoundDown2) + blockDistance2)
            {
                result = Math.Abs(destinationRoundUp2 - destination[1]) + (departureRoundUp2 - departure[1]) + blockDistance2;
            }
            else 
            {
                result = Math.Abs(destination[1] - departureRoundDown2) + (departure[1] + departureRoundDown2) + blockDistance2; 
            }
        
        }
    
    
    
    return result;
    
    //
}

