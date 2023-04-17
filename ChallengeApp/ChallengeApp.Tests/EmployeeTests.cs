namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void ShowsMinValue()
        {
            
            var employee = new Employee("Marek", "Marecki");

            employee.AddScore(1);
            employee.AddScore(2);
            employee.AddScore(2);
            
            var statistic = employee.GetStatistics();
            
            Assert.AreEqual(1, statistic.Min);
        }

        [Test]
        public void ShowsMaxValue()
        {

            var employee = new Employee("Marek", "Marecki");

            employee.AddScore(5);
            employee.AddScore(4);
            employee.AddScore(4);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(5, statistic.Max);
        }

        [Test]
        public void ShowsAverage()
        {

            var employee = new Employee("Marek", "Marecki");

            employee.AddScore(2);
            employee.AddScore(6);
            employee.AddScore(4);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(4, statistic.Average);
        }
    }
}