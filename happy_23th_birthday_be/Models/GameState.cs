namespace happy_23th_birthday_be.Models
{
    public class GameState
    {
        public int CurrentQuestionIndex { get; set; } = 0;
        public List<int> UnlockedRewardIds { get; set; } = new();
        public List<int> ClaimedRewardIds { get; set; } = new();
        public bool IsQuizCompleted { get; set; } = false;
        public bool FinalMessageRead { get; set; } = false;
    }
}