namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname, string jobpost) 
            : base(name, surname, jobpost)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("[Błędna wartość oceny]");
            }
        }
        public override Statistics GetStattistics()
        {
            return CalculateStattistics();
        }
    }
}
