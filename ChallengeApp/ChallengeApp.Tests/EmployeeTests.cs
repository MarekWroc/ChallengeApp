namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void ShowsMinValue()
        {
            
            var employee = new Employee("Marek", "Marecki");

            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(2);
            
            var statistic = employee.GetStatistics();
            
            Assert.AreEqual(1, statistic.Min);
        }

        [Test]
        public void ShowsMaxValue()
        {

            var employee = new Employee("Marek", "Marecki");

            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(4);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(5, statistic.Max);
        }

        [Test]
        public void ShowsAverage()
        {

            var employee = new Employee("Marek", "Marecki");

            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(4);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(4, statistic.Average);
        }
    }
}