using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Walks.Data;

public class WalksAuthDbContext : IdentityDbContext
{
    public WalksAuthDbContext(DbContextOptions<WalksAuthDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seeding data for Roles
        var roles = new List<IdentityRole>(){
            new IdentityRole { Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString(), Name = "Reader", NormalizedName = "READER" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString(), Name = "Writer", NormalizedName = "WRITER" }
        };

        modelBuilder.Entity<IdentityRole>().HasData(roles);
    }
}
