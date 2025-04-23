using System;

public class School
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
    public string District { get; set; }
    public string Rank { get; set; }
	public virtual ICollection<Hero> Heroes { get; set; }

    public School()
	{

	}
}
