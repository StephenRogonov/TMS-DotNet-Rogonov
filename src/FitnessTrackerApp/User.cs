namespace FitnessTrackerApp
{
    class User
    {
        public User(double weight, double height, string gender, int age)
        {
            Weight = weight;
            Height = height;
            Gender = gender;
            Age = age;
        }

        public double Weight { get; set; }
        public double Height { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public double CaloriesNorm()
        {
            double caloriesPerDay;
            if (Gender.Equals("M"))
            {
                caloriesPerDay = 10 * Weight + 6.25 * Height - 5 * Age + 5;
            }
            else
            {
                caloriesPerDay = 10 * Weight + 6.25 * Height - 5 * Age - 161;
            }

            return caloriesPerDay;
        }
    }
}
