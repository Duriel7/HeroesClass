using System;

namespace BNHA.Models
{
    public class Power
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public char Rank { get; set; }
        public virtual Hero Owner { get; set; }
        public Power()
        {

        }
    }
}
