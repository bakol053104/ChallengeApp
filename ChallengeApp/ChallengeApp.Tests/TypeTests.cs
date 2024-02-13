namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ReferenceTypeTest()
        {
            // arrange
            var employee1 = GetEmployee("Imie_1", "Nazwisko_1", 21);
            var employee2 = GetEmployee("Imie_1", "Nazwisko_1", 21);

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void IntTypeTest()
        {
            // arrange
            var employee1 = GetEmployee("Imie_1", "Nazwisko_1", 21);
            var employee2 = GetEmployee("Imie_2", "Nazwisko_2", 21);

            // assert
            Assert.AreEqual(employee1.Age, employee2.Age);
        }

        [Test]
        public void StringTypeTest()
        {
            // arrange
            var employee1 = GetEmployee("Imie_1", "Nazwisko_1", 21);
            var employee2 = GetEmployee("Imie_1", "Nazwisko_2", 23);

            // assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }

        [Test]
        public void FloatTypeTest()
        {
            // arrange
            var number1 = 3.14;
            var number2 = 6.28;

            var expectedResult = 2 * number1;

            // assert
            Assert.AreEqual(expectedResult, number2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
