namespace RepartitionTournoi.Models
{
    public class Match
    {
        public Match()
        {
            Scores = new List<Score>();
        }
        public int Id { get; set; }
        public List<Score> Scores { get; set; }
    }
}
