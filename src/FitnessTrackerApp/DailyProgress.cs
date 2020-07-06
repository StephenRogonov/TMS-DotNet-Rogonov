namespace FitnessTrackerApp
{
    class DailyProgress
    {
        private int _consumed;
        private double _norm;
        private double _burned;

        public DailyProgress(int consumed, double norm, double burned)
        {
            _consumed = consumed;
            _norm = norm;
            _burned = burned;
        }        

        public double DailyDeviation()
        {
            double deviation = (_consumed - _burned) - _norm;
            return deviation;
        }        
    }
}
