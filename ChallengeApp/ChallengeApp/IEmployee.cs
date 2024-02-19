namespace ChallengeApp
{
    public interface IEmployee    
    {
        string Name { get; }

        string Surname { get; }

        string JobPost { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        Statistics GetStattistics();
    }
}
