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
            new Question
            {
                Id = 2,
                Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Choices = new Dictionary<string, string>
                {
                    { "A", "Code-First" },
                    { "B", "Database-First" },
                    { "C", "Model-First" },
                    { "D", "Controller-First" },
                },
                Answer = "B"
            },
             new Question
            {
                Id = 3,
                Text = "What is the primary purpose of Entity Framework Core?",
                Choices = new Dictionary<string, string>
                {
                    { "A", "To create HTML pages automatically" },
                    { "B", "To replace the MVC Controller" },
                    { "C", "To map objects in code to relational database data" },
                    { "D", "To replace the C# compiler" },
                },
                Answer = "C"
            },
        };
    }
}