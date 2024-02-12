namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckResultWithoutPenaltyPoints()
        {
            // arrange
            var employee= new Employee ("Imie_1", "Nazwisko_1", 21);
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(7);
            
            var expectedResult=1 + 5 + 7;
            
            // act
            var result =employee.Result;

            // assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void CheckResultWithPenaltyPoints()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1", 21);
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(9);
            employee.AddGrade(7);
            employee.SetPenaltyPoints(-10);

            var expectedResult = 1 + 5 + 7 + 9 + 7 - 10;

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CheckResultWithPenaltyPoints_PenaltyPointsFirstElementList()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1", 21);
            
            employee.SetPenaltyPoints(-8);
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(7);
            employee.AddGrade(10);
            
            var expectedResult = -8 + 1 + 5 + 7 + 7 + 10;

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CheckResultWithPenaltyPoints_PenaltyPointsMiddleElementList()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1", 21);

            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.SetPenaltyPoints(-5);
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(2);

            var expectedResult = 1 + 5 - 5 + 7 + 8 + 2;

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(expectedResult, result);

        }
        [Test]
        public void CheckResultWithPenaltyPoints_ChangeValuePenaltyPoints()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1", 21);

            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.SetPenaltyPoints(-5);
            employee.AddGrade(7);
            employee.AddGrade(1);
            employee.AddGrade(4);
            employee.SetPenaltyPoints(-3);

            var expectedResult = 1 + 5 + 7 + 1 + 4 - 3;

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void CheckResultWithPenaltyPoints_ResetPenaltyPoints()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1", 21);

            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.SetPenaltyPoints(-6);
            employee.AddGrade(7);
            employee.AddGrade(1);
            employee.AddGrade(4);
            employee.SetPenaltyPoints(0);

            var expectedResult = 1 + 5 + 7 + 1 + 4 + 0;

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void CheckResultWithoutPenaltyPoints_GradesBetween_1_10()
        {
            // arrange
            var employee = new Employee("Imie_1", "Nazwisko_1", 21);

            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(17);
            employee.AddGrade(1);
            employee.AddGrade(-4);
          

            var expectedResult = 1 + 5 + 1;

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(expectedResult, result);

        }
    }
 }