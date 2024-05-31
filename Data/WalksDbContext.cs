using Microsoft.EntityFrameworkCore;
using Walks.Models.Domain;

namespace Walks.Data;

public class WalksDbContext : DbContext
{
    public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options) { }
    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }
    public DbSet<Image> Images { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seeding data for Difficulties
        var difficulties = new List<Difficulty>(){
            new Difficulty { Id = Guid.Parse("f808ddcd-b5e5-4d80-b732-1ca523e48434"), Name = "Hard" },
            new Difficulty { Id = Guid.Parse("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"), Name = "Easy" },
            new Difficulty { Id = Guid.Parse("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), Name = "Medium" }
        };

        // Seeding data for Regions
        var regions = new List<Region>(){
            new Region { Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), Code = "NSN", Name = "Nelson", RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
            new Region { Id = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"), Code = "AKL", Name = "Auckland", RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
            new Region { Id = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"), Code = "BOP", Name = "Bay Of Plenty" },
            new Region { Id = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), Code = "NTL", Name = "Northland" },
            new Region { Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"), Code = "STL", Name = "Southland" },
            new Region { Id = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"), Code = "WGN", Name = "Wellington", RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
        };

        // Seeding data for Walks
        var walks = new List<Walk>(){
            new Walk
            {
                Id = Guid.Parse("327aa9f7-26f7-4ddb-8047-97464374bb63"),
                Name = "Mount Victoria Loop",
                Description = "This scenic walk takes you around the top of Mount Victoria, offering stunning views of Wellington and its harbor.",
                LengthInKm = 3.5,
                WalkImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                RegionId = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de")
            },
            new Walk
            {
                Id = Guid.Parse("b4c2f4c5-948d-4f35-b8c7-3f116ed762f1"),
                Name = "Tongariro Alpine Crossing",
                Description = "Experience the diverse landscapes of the Tongariro National Park, from alpine meadows to volcanic craters.",
                LengthInKm = 19.4,
                WalkImageUrl = "https://images.pexels.com/photos/414171/pexels-photo-414171.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                RegionId = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81")
            },
            new Walk
            {
                Id = Guid.Parse("e9b1f9a1-f9df-4f1a-b830-3a7f564db1a1"),
                Name = "Milford Track",
                Description = "One of New Zealand's most famous walks, the Milford Track offers stunning scenery in Fiordland National Park.",
                LengthInKm = 53.5,
                WalkImageUrl = "https://images.pexels.com/photos/315566/pexels-photo-315566.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                RegionId = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263")
            },
            new Walk
            {
                Id = Guid.Parse("f4316efb-dc14-42e8-94fc-7e6e9b6b2499"),
                Name = "Kepler Track",
                Description = "A circular track through the stunning landscapes of Fiordland National Park, including lakes, forests, and alpine vistas.",
                LengthInKm = 60.0,
                WalkImageUrl = "https://images.pexels.com/photos/1148820/pexels-photo-1148820.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                RegionId = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263")
            },
            new Walk
            {
                Id = Guid.Parse("bc1b4295-1dd4-4d21-9475-8f15eb2d43e4"),
                Name = "Routeburn Track",
                Description = "A world-renowned track that passes through beech-forested valleys and alpine gardens.",
                LengthInKm = 32.0,
                WalkImageUrl = "https://images.pexels.com/photos/417073/pexels-photo-417073.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                RegionId = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263")
            },
            new Walk
            {
                Id = Guid.Parse("14f243bc-42a0-470a-bd37-154b2c53b8b1"),
                Name = "Abel Tasman Coast Track",
                Description = "A coastal walk offering golden beaches and lush, native bush.",
                LengthInKm = 60.0,
                WalkImageUrl = "https://images.pexels.com/photos/12052345/pexels-photo-12052345.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                RegionId = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6")
            },
            new Walk
            {
                Id = Guid.Parse("46e9a1d2-34fa-4a2b-bc02-f53a0e61492f"),
                Name = "Heaphy Track",
                Description = "A track that offers diverse landscapes from forested valleys to the rugged west coast.",
                LengthInKm = 78.4,
                WalkImageUrl = "https://images.pexels.com/photos/410999/pexels-photo-410999.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                RegionId = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6")
            },
            new Walk
            {
                Id = Guid.Parse("9fc5fbb1-0b58-4d64-bf70-4e0cbff1259c"),
                Name = "Lake Waikaremoana Great Walk",
                Description = "A walk through ancient rainforests and along the shores of the lake.",
                LengthInKm = 46.0,
                WalkImageUrl = "https://images.pexels.com/photos/1230343/pexels-photo-1230343.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                RegionId = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81")
            },
            new Walk
            {
                Id = Guid.Parse("a3d6f7c1-1b4d-4c12-8f2f-9e3e8edc18f1"),
                Name = "Whanganui Journey",
                Description = "A journey down the Whanganui River by canoe or kayak, including a few short walks.",
                LengthInKm = 145.0,
                WalkImageUrl = "https://images.pexels.com/photos/4386375/pexels-photo-4386375.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                RegionId = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81")
            },
            new Walk
            {
                Id = Guid.Parse("b7e7c4c2-8ed4-4d15-bcd8-7957402901f7"),
                Name = "Rakiura Track",
                Description = "A journey through the native forest, coastline, and the unique environment of Stewart Island.",
                LengthInKm = 32.0,
                WalkImageUrl = "https://images.pexels.com/photos/1661214/pexels-photo-1661214.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                RegionId = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263")
            },
            new Walk
            {
                Id = Guid.Parse("73d9e4f1-64b7-4c7f-9620-82952af31f15"),
                Name = "Te Araroa Trail",
                Description = "A trail stretching from Cape Reinga in the north to Bluff in the south, covering a variety of landscapes.",
                LengthInKm = 3000.0,
                WalkImageUrl = "https://images.pexels.com/photos/417074/pexels-photo-417074.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                RegionId = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81")
            },
            new Walk
            {
                Id = Guid.Parse("c2c6bdea-4f1f-40c3-a2a5-5f1b52779b98"),
                Name = "Queen Charlotte Track",
                Description = "A track that offers spectacular views of Queen Charlotte Sound.",
                LengthInKm = 70.0,
                WalkImageUrl = "https://images.pexels.com/photos/1884318/pexels-photo-1884318.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                RegionId = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6")
            },
            new Walk
            {
                Id = Guid.Parse("a54d9f7f-4b8f-4d64-89a7-1f64c0dbf6a5"),
                Name = "Hump Ridge Track",
                Description = "A track offering a unique mix of historic viaducts, lush forest, and sub-alpine terrain.",
                LengthInKm = 61.0,
                WalkImageUrl = "https://images.pexels.com/photos/2906327/pexels-photo-2906327.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                RegionId = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263")
            },
            new Walk
            {
                Id = Guid.Parse("d51e5f8b-758e-45c4-965a-d839f2f2a94c"),
                Name = "Copland Track",
                Description = "A challenging track leading to the Welcome Flat hot springs.",
                LengthInKm = 17.0,
                WalkImageUrl = "https://images.pexels.com/photos/216671/pexels-photo-216671.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                RegionId = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6")
            },
            new Walk
            {
                Id = Guid.Parse("3e4b43b2-7d4e-4bbd-9c7a-3b8c0b01b2b1"),
                Name = "Crater Rim Walk",
                Description = "A walk along the rim of an ancient volcano with panoramic views of Christchurch and Lyttelton Harbour.",
                LengthInKm = 16.0,
                WalkImageUrl = "https://images.pexels.com/photos/4413802/pexels-photo-4413802.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                DifficultyId = Guid.Parse("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                RegionId = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6")
            }
        };

        // Actual seeding
        modelBuilder.Entity<Difficulty>().HasData(difficulties);
        modelBuilder.Entity<Region>().HasData(regions);
        modelBuilder.Entity<Walk>().HasData(walks);
    }

}