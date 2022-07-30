namespace RepartitionTournoi.Models
{
    public class MatchDTO
    {
        public MatchDTO()
        {
            Scores = new List<ScoreDTO>();
        }
        public int Id { get; set; }
        public List<ScoreDTO> Scores { get; set; }
    }
}
