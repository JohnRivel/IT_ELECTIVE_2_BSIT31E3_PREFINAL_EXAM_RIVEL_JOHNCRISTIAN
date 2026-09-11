using ExamReviewer.Models;

namespace ExamReviewer.Data
{
    public class QuestionBank
    {
        public static List<Question> All { get; } = new()
        {
            new Question
            {
                Id = 1,
                Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                Choices = new Dictionary<string, string>
                {
                    { "A", "It makes C# code shorter" },
                    { "B", "It prevents the application from restarting" },
                    { "C", "It allows data to persist after the application stops" },
                    { "D", "It removes the need for MVC" }
                },
                Answer = "C"
            },
        };
    }
}