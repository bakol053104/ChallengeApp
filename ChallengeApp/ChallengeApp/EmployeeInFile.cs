namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
       : base(name, surname)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
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

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("[Nie znaleziono pliku grades.txt]");
            }
            return statistics;
        }
    }
}



