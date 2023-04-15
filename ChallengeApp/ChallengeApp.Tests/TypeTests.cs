namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareTwoSameInts() // check value
        {
            // arrange
            int number1 = 1;
            int number2 = 1;
            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareTwoDifferentInts() // check value
        {
            // arrange
            int number1 = 1;
            int number2 = 2;
            // act

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
            public void CompareTwoSameFloats() // check value
        {
            // arrange
            float number1 = 1.5f;
            float number2 = 1.5f;
            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareTwoDifferentFloats() // check value
        {
            // arrange
            float number1 = 1.12f;
            float number2 = 1.3f;
            // act

            // assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldReturnDiferentObjects() // check reference
        {
            // arrange
            var employee1 = GetEmployee("Marek");
            var employee2 = GetEmployee("Marek");
            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
