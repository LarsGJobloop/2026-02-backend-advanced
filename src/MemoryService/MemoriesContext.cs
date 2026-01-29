using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

public class MemoriesContext : DbContext
{
  public DbSet<UserMemory> Memories { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User=admin;Passord=password;Database=memories");
}

public class UserMemory
{
  public required int Id { get; init; }
  public required string Content { get; init; }
}
