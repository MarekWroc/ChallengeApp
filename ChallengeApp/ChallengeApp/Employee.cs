namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Value
        { 
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int NewScore)
        {
            this.score.Add(NewScore);
        }
        public void SubtractScore(int NewScore)
        {
            this.score.Add(-NewScore);
        }
    }
}
