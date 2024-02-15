using ChallengeApp;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        private void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("\nBłędna wartość oceny");
            }

        }

        public void AddGrade(char grade)
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
                    Console.WriteLine("Wprowadzono nieprawidłową literę\n");
                    break;
            }

        }

        public void AddGrade(string grade)

        {
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
                Console.WriteLine("Łańcuch znaków nie jest liczbą\n");
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


            return statistics;

        }

    }
}