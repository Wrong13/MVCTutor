using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class BnsContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public BnsContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder Optionsbuilder)
    {
        Optionsbuilder.UseMySql(
            "server=localhost;user=root;password=passtobeadmin;database=MVCTutordb;",
            new MySqlServerVersion(new Version(8, 0, 29))
        );
    }
}