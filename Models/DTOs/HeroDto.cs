namespace BNHA.Models.DTOs
{
    public class HeroDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public char Rank { get; set; }
        public string School { get; set; }
        public List<string> Powers { get; set; }
    }
}
