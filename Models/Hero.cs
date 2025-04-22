using System;
using Heroes;

public class Hero
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Year { get; set; }
	public char Rank { get; set; }
	public virtual School School { get; set; }
	public virtual ICollection<Power> Powers { get; set; }

    public Hero()
	{

	}
}
