namespace RepartitionTournoi.Models
{
    public class MatchDTO
    {
        public MatchDTO()
        {
            Scores = new List<ScoreDTO>();
        }
        public long Id { get; set; }
        public string Nom { get; set; }
        public List<ScoreDTO> Scores { get; set; }
    }
}
