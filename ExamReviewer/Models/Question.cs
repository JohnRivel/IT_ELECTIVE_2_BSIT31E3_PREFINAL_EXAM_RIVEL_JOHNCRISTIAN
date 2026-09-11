namespace ExamReviewer.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public Dictionary<string, string> Choices { get; set; } = new();
        public string Answer { get; set; } = string.Empty;
    }
}