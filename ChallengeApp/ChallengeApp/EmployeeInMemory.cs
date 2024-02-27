namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                CallEventGradeAdded();
            }
            else
            {
                throw new Exception("[Błędna wartość oceny]");
            }
        }

        public override Statistics GetStattistics()
        {
            Statistics statistics = new Statistics();

            if (this.grades.Count > 0)
            {
                foreach (var grade in this.grades)
                {
                    statistics.AddGrade(grade);
                }
            }
            else
            {
                throw new Exception("[Brak wprowadzonych ocen]");
            }
            return statistics;
        }
    }
}
