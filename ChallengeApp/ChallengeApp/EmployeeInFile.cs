namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, string jobpost)
       : base(name, surname, jobpost)
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

            WriteGradesToFile();
        }

        public override Statistics GetStattistics()
        {
            ReadGradesFromFile();
            return CalculateStattistics();
        }

        private void WriteGradesToFile()
        {
            if (File.Exists(fileName)) { File.Delete(fileName); }

            foreach (var grade in grades)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
        }

        private void ReadGradesFromFile()
        {
            grades.Clear();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        this.grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new Exception("[Nie znaleziono pliku grades.txt]");
            }

        }
    }
}



