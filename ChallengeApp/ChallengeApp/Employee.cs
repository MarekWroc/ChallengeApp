namespace ChallengeApp
{
    public class Employee
    {
        private List<int> scores = new List<int>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Value
        { 
            get
            {
                return this.scores.Sum();
            }
        }

        public void AddScore(int NewScore)
        {
            this.scores.Add(NewScore);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach(var score in this.scores)
            {
                statistics.Average += score;
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Min = Math.Max(statistics.Max, score);
            }

            statistics.Average /= this.scores.Count;
            return statistics;
        }
    }
}
