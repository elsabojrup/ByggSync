using System;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	public DbSet<Question> Questions { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder) 
	{
		base.OnModelCreating(modelBuilder);
	}
}
