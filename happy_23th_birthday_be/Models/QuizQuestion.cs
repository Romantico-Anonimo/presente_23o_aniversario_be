namespace happy_23th_birthday_be.Models
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public int CorrectAnswerIndex { get; set; }
        public int RewardId { get; set; }
    }
}
