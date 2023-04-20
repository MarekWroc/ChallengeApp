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
        [Test]
        public void GetLetterValue_ReturnNumericAverage()
        {
            var employee = new Employee("Marek", "Marecki");

            employee.AddGrade('a');
            employee.AddGrade('A');
            employee.AddGrade('A');

            var statistic = employee.GetStatistics();

            Assert.AreEqual(100, statistic.Average);
        }
        [Test]
        public void GetMixedValue_ReturnNumericAverage()
        {
            var employee = new Employee("Marek", "Marecki");

            employee.AddGrade('a');
            employee.AddGrade("100");
            employee.AddGrade('A');
            employee.AddGrade(100);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(100, statistic.Average);
        }
        [Test]
        public void GetNumericValue_ReturnNumericAverage()
        {
            var employee = new Employee("Marek", "Marecki");

            employee.AddGrade(20);
            employee.AddGrade(20);
            employee.AddGrade(20);
            employee.AddGrade(20);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(20, statistic.Average);
        }
        [Test]
        public void GetMixedValue_ReturnLetterAverage()
        {
            var employee = new Employee("Marek", "Marecki");

            employee.AddGrade('a');
            employee.AddGrade("40");
            employee.AddGrade('A');
            employee.AddGrade(100);

            var statistic = employee.GetStatistics();

            Assert.AreEqual('A', statistic.AverageLetter);
        }
    }
}