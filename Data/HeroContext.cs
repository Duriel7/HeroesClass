using System;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class HeroContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    public HeroContext(DbContextOptions<HeroContext> options) : base(options)
    {
    }

    public DbSet<Hero> Heroes { get; set; }

    public DbSet<Power> Powers { get; set; }

    public DbSet<School> Schools { get; set; }
}
