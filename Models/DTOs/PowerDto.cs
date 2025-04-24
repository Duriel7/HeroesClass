namespace BNHA.Models.DTOs
{
    public class PowerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public char Rank { get; set; }
        public List<string>? Owners { get; set; }
    }
}
