namespace BNHA.Models.DTOs
{
    public class SchoolDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string District { get; set; }
        public string Rank { get; set; }
        public List<string> Heroes { get; set; }
    }
}
