

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
            this.Jobpost = "Kierownik";
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Jobpost { get; private set; }

        public void AddGrade(float grade)
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

        public void AddGrade(string grade)
        {
            if (grade.Length >= 1 && grade.Length <= 2)
            {

                var result = 0f;
                var index = 0;
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
                AddGrade(result);
            }
            else
            {
                throw new Exception("[Ocena nie składa się z odpowiedniej ilości znaków]");
            }
        }

        public Statistics GetStattistics()
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
            return statistics;
        }
    }
}

