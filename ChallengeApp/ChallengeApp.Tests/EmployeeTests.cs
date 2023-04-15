namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectPoints_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Marek", 40);
            employee.AddScore(2);
            employee.AddScore(7);
            employee.SubtractScore(1); // or employee.AddScore(-1);
            employee.AddScore(4);
            employee.SubtractScore(11); // or employee.AddScore(-11);
            // act
            var value = employee.Value;
            // assert
            Assert.AreEqual(1, value);
        }
    }
}