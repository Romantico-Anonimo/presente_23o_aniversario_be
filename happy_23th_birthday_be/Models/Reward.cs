namespace happy_23th_birthday_be.Models
{
    public class Reward
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsClaimed { get; set; }
    }
}
