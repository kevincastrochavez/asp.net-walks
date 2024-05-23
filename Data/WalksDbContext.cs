using Microsoft.EntityFrameworkCore;
using Walks.Models.Domain;

namespace Walks.Data;

public class WalksDbContext : DbContext
{
    public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options) { }
    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }

}