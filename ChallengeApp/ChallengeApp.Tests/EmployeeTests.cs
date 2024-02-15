namespace ChallengeApp.Tests
{
    public class Employeetests
    {
        [Test]
        public void CheckResult_UpperCaseLettersInput()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("A");
            employee.AddGrade("B");
            employee.AddGrade("C");
            employee.AddGrade("D");
            employee.AddGrade("E");


            var expectedResult = (float)(100 + 80 + 60 + 40 + 20) / 5;

            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, statistics.Average);
        }

        [Test]
        public void CheckResult_UpperCaseLettersInput_WithInvalidValue()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("A");
            employee.AddGrade("B");
            employee.AddGrade("F");
            employee.AddGrade("P");


            var expectedResult = (float)(100 + 80) / 2;

            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, statistics.Average);
        }

        [Test]
        public void CheckResult_LowerCaseLettersInput()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("a");
            employee.AddGrade("b");
            employee.AddGrade("c");
            employee.AddGrade("d");
            employee.AddGrade("e");


            var expectedResult = (float)(100 + 80 + 60 + 40 + 20) / 5;

            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, statistics.Average);
        }
        [Test]
        public void CheckResult_LowerCaseLettersInput_WithInvalidValue()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("a");
            employee.AddGrade("b");
            employee.AddGrade("z");
            employee.AddGrade("k");
            employee.AddGrade("f");


            var expectedResult = (float)(100 + 80) / 2;

            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, statistics.Average);
        }

        [Test]
        public void CheckResult_LettersAndDigitsInput()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("a");
            employee.AddGrade("B");
            employee.AddGrade("1");
            employee.AddGrade("8");
            employee.AddGrade("9");


            var expectedResult = (float)(100 + 80 + 1 + 8 + 9) / 5;

            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, statistics.Average);
        }

        [Test]
        public void CheckResult_LettersAndNumbersInput()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("a");
            employee.AddGrade("B");
            employee.AddGrade("10");
            employee.AddGrade("88,8");
            employee.AddGrade("9,99");


            var expectedResult = (float)(100 + 80 + 10 + 88.8 + 9.99) / 5;
            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(Math.Round(expectedResult), Math.Round(statistics.Average));
        }

        [Test]
        public void CheckResult_LettersAndNumbersInput_WithInvalidValue()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("a");
            employee.AddGrade("B");
            employee.AddGrade("10");
            employee.AddGrade("8");
            employee.AddGrade("999");
            employee.AddGrade("asada");
            employee.AddGrade("H");
            employee.AddGrade("m");
            employee.AddGrade("1");


            var expectedResult = (float)(100 + 80 + 10 + 8 + 1) / 5;
            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(Math.Round(expectedResult), Math.Round(statistics.Average));
        }

        [Test]
        public void CheckResult_WithoutGrades()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1");
            employee.AddGrade("999");
            employee.AddGrade("mmmm");
            employee.AddGrade("Hfff");
            employee.AddGrade("m");
            employee.AddGrade("G");

            Statistics expectedResult = null;

            // act
            var statistics = employee.GetStattistics();

            // assert
            Assert.AreEqual(expectedResult, statistics);
        }
    }
}
