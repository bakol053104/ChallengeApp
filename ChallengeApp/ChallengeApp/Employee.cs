namespace ChallengeApp
{
    public class Employee
    {
        public List<int> grades = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public void AddGrade(int grade)
        {
            if (grade >= 1 && grade <= 10)
            {
                this.grades.Add(grade);
            }
        }
        public void SetPenaltyPoints(int points)
        {

            if (points > 0) return;

            var index = SearchPenaltyPointsInGrades();
            if (index == -1)
            {
                this.grades.Add(points);
            }
            else
            {
                this.grades[index] = points;
            }

        }

        private int SearchPenaltyPointsInGrades()
        {
            var index = 0;
            foreach (var grade in grades)
            {
                if (grade <= 0) return index;
                index++;
            }
            return -1;

        }
    }
}
