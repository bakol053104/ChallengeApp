namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        protected List<float> grades = new List<float>();

        public EmployeeBase(string name, string surname, string jobpost)
        {
            this.Name = name;
            this.Surname = surname;
            this.JobPost = jobpost;
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
            switch (JobPost)
            {
                case "Pracownik":
                    if ((grade.Length == 1) && ((grade[0] >= 'A' && grade[0] <= 'Z') || (grade[0] >= 'a' && grade[0] <= 'z')))
                    {
                        AddGrade(grade[0]);
                    }
                    else if (float.TryParse(grade, out float result))
                    {
                        AddGrade(result);
                    }
                    else
                    {
                        throw new Exception("[Łańcuch znaków nie jest liczbą]");
                    }
                    break;
                case "Kierownik":
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
                    break;
                default:
                    throw new Exception("Wprowadzono nieprawidłowe stanowisko pracy");
            }

        }

        protected Statistics CalculateStattistics()
        {
            if (this.grades.Count == 0)
            {
                return null;
            }
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;

            switch (JobPost)
            {
                case "Pracownik":
                    switch (statistics.Average)
                    {
                        case var average when average > 80:
                            statistics.AverageLetter = 'A';
                            break;
                        case var average when average > 60 && average <= 80:
                            statistics.AverageLetter = 'B';
                            break;
                        case var average when average > 40 && average <= 60:
                            statistics.AverageLetter = 'C';
                            break;
                        case var average when average > 20 && average <= 40:
                            statistics.AverageLetter = 'D';
                            break;
                        default:
                            statistics.AverageLetter = 'E';
                            break;
                    }
                    break;
                case "Kierownik":
                    switch (statistics.Average)
                    {
                        case var average when average >= 95:
                            statistics.AverageLetter = '6';
                            break;
                        case var average when average >= 75 && average < 95:
                            statistics.AverageLetter = '5';
                            break;
                        case var average when average >= 55 && average < 75:
                            statistics.AverageLetter = '4';
                            break;
                        case var average when average > 35 && average < 55:
                            statistics.AverageLetter = '3';
                            break;
                        case var average when average > 15 && average < 35:
                            statistics.AverageLetter = '2';
                            break;
                        default:
                            statistics.AverageLetter = '1';
                            break;
                    }
                    break;
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

        private void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("[Wprowadzono nieprawidłową literę]");
            }

        }
    }
}
