using System;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Heroes;

public class HeroContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source = Duriel-Laptop; Initial Catalog = DurielHeroesClass; Integrated Security = True; Trust Server Certificate = True");
    }
    public HeroContext(DbContextOptions<HeroContext> options) : base(options)
    {    }

    public DbSet<Hero> Heroes { get; set; }
}
