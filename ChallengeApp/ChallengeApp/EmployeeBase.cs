namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        protected List<float> grades = new List<float>();

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public delegate void GradeAdddedDelegate(object sender, EventArgs args);

        public event GradeAdddedDelegate GradeAdded;

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string JobPost { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract Statistics GetStattistics();

        public void AddGrade(string grade)
        {
            if (grade.Length >= 1 && grade.Length <= 2)

            {
                float result = 0;
                int index = 0;
                var isDigit = false;

                foreach (var item in grade)
                {
                    switch (grade[index])
                    {
                        case var value when value >= 49 && value <= 54 && !isDigit:
                            result += (grade[index] - 49) * 20;
                            isDigit = true;
                            break;
                        case var value when value == 43:
                            result += 5;
                            break;
                        case var value when value == 45:
                            result -= 5;
                            break;
                        default:
                            throw new Exception("[Wprowadzono nieprawidłową ocenę]");
                    }
                    index++;
                }
                if (isDigit)
                {
                    AddGrade(result);
                }
                else
                {
                    throw new Exception("[Ocena nie zawiera cyfry pomiędzy 1-6]");
                }
            }
            else
            {
                throw new Exception("[Ocena nie składa się z odpowiedniej ilości znaków]");
            }
        }

        protected Statistics CalculateStattistics()
        {
            Statistics statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }

        protected void CallEventGradeAdded()
        {
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

    }
}
