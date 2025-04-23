using System;

public class Power
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
    public int Level { get; set; }
    public char Rank { get; set; }
    public virtual ICollection<Hero> Owners { get; set; }
    public Power()
	{

	}
}
