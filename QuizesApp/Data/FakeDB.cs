namespace QuizesApp.Data;

public class FakeDB : IFakeDB
{
    public FakeDB()
    {
        Quizzes = SeedData();
    }

    public List<Quiz>? Quizzes { get; set; } = [];

    public class Quiz()
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public List<Question>? Questions { get; set; }
    }

    public class Question()
    {
        public int? Id { get; set; }
        public string? Text { get; set; }
        public List<Answer>? Answers { get; set; }
        public bool IsCorrect 
        {
            get => isCorrect; 
            set => isCorrect = value; 
        }
        private bool isCorrect;

        public void AnswerSubmitted()
        {
            if (Answers is not null)
            foreach (var answer in Answers)
            {
                if (answer.IsCorrect && answer.IsSelected)
                {
                    IsCorrect = true;
                }
            }
            IsCorrect = false;
        }
    }

    public class Answer()
    {
        public int? Id { get; set; }
        public string? Text { get; set; }
        public string? Explanation { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsSelected { get; set; } = false;
    }

    public List<Quiz> SeedData()
    {
        var a1 = new Answer
        {
            Id = 1,
            Text = "4",
            Explanation = "2 + 2 = 4",
            IsCorrect = true
        };
        var a2 = new Answer
        {
            Id = 2,
            Text = "7",
            Explanation = "Its not 7, thats too much",
            IsCorrect = false
        };
        var a3 = new Answer
        {
            Id = 3,
            Text = "3",
            Explanation = "Its not 3, thats too little",
            IsCorrect = false
        };

        var q1 = new Question
        {
            Id = 1,
            Text = "What is 2 + 2?",
            Answers = [a1, a2, a3]
        };

        var quiz = new Quiz
        {
            Id = 1,
            Name = "Test Quiz",
            Questions = [q1]
        };

        var list = new List<Quiz> { quiz };
        return list;
    }
}
