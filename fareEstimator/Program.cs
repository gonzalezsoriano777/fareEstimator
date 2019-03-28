using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fareEstimator
{
    public class Ride
    {
       public double[] FareEstimator(int ride_time, int ride_distance, double[] cost_per_minute, double[] cost_per_mile)
        {

            double[] fareEstimator = new double[cost_per_mile.Length];

            for(int i = 0; i < cost_per_mile.Length; i++)
            {
                fareEstimator[i] = (double)(cost_per_minute[i]* ride_time) + (double)(cost_per_mile[i] * ride_distance);
            }

            return fareEstimator;

        }
    }
}
