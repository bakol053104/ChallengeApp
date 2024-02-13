namespace ChallengeApp.Tests
{
    public class Employeetests
    {
        [Test]
        public void CheckResultMaxValue()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(7);

            var expectedResult = 7;

            // act
            var result = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, result.Max);
        }

        [Test]
        public void CheckResultMinValue()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(7);

            var expectedResult = 1;

            // act
            var result = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, result.Min);
        }

        [Test]
        public void CheckResulAvarageValue()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(7);

            var expectedResult = (float)(1 + 5 + 7) / 3;

            // act
            var result = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, result.Average);
        }

    }
}