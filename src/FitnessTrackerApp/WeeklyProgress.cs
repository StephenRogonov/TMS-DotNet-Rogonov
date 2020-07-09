using System.Collections.Generic;

namespace FitnessTrackerApp
{
    class WeeklyProgress
    {
        public IList<double> deviationFromNorm = new List<double>();

        public double WeeklyScore()
        {
            double sum = 0;
            foreach (double d in deviationFromNorm)
            {
                sum += d;
            }
            return sum;
        }
    }
}
