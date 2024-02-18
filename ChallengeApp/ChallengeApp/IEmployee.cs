namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        string Jobpost { get; }

        void AddGrade(string grade);

        Statistics GetStattistics();
    }
}
