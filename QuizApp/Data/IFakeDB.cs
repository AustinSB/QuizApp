
namespace QuizApp.Data
{
    public interface IFakeDB
    {
        List<FakeDB.Quiz>? Quizzes { get; set; }

        List<FakeDB.Quiz> SeedData();
    }
}