using Microsoft.EntityFrameworkCore;
using Walks.Models.Domain;

namespace Walks.Data;

public class WalksDbContext : DbContext
{
    public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options) { }
    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data for the difficulties
        var difficulties = new List<Difficulty>() {
            new Difficulty()
            {
                Id = Guid.Parse("2201c851-ba47-47ea-aadf-bb9b7ac80216"),
                Name = "Easy"
            },
            new Difficulty()
            {
                Id = Guid.Parse("8d8e7199-0409-4cea-8d33-6eabdaeb7d50"),
                Name = "Medium"
            },
            new Difficulty()
            {
                Id = Guid.Parse("45359600-275a-4179-a2d3-c375b7a3dca8"),
                Name = "Hard"
            }
        };

        // Seed data for the regions
        var regions = new List<Region>() {
            new Region()
            {
                Id = Guid.Parse("8b9399fc-980d-44fd-aafa-e896f9637103"),
                Code = "LAR",
                Name = "Larnaca",
                RegionImageUrl = "https://images.unsplash.com/photo-1515896480369-9c67a87f4ca8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
            },
            new Region()
            {
                Id = Guid.Parse("dc1cae41-d002-4ae6-a829-0065c17ed534"),
                Code = "VNO",
                Name = "Vilnius",
                RegionImageUrl = "https://images.unsplash.com/photo-1542601904570-411afe2eab2a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
            },
            new Region()
            {
                Id = Guid.Parse("1b8e159e-5345-42aa-be45-57dec1ed71bd"),
                Code = "RIX",
                Name = "Riga",
                RegionImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
            },
            new Region()
            {
                Id = Guid.Parse("e7dd40f4-32a8-4e97-978e-281764a355e6"),
                Code = "KLA",
                Name = "Klaipeda",
                RegionImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
            }
        };

        // Actual seeding
        modelBuilder.Entity<Difficulty>().HasData(difficulties);
        modelBuilder.Entity<Region>().HasData(regions);
    }

}