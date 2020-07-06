namespace FitnessTrackerApp
{
    class Exercises
    {
        public Exercises(double running, double swimming, double walking)
        {
            Running = running;
            Swimming = swimming;
            Walking = walking;
        }

        public double Running { get; set; }
        public double Swimming { get; set; }
        public double Walking { get; set; }

        public double Burned(double weight)
        {
            double runBurn = Running * weight * 1;
            double swimBurn = Swimming * weight * 6;
            double walkBurn = Walking * weight * 4.5;
            return runBurn + swimBurn + walkBurn;
        }
    }
}
