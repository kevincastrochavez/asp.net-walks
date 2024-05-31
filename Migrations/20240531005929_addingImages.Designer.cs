﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Walks.Data;

#nullable disable

namespace Walks.Migrations
{
    [DbContext(typeof(WalksDbContext))]
    [Migration("20240531005929_addingImages")]
    partial class addingImages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Walks.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                            Name = "Hard"
                        },
                        new
                        {
                            Id = new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                            Name = "Medium"
                        });
                });

            modelBuilder.Entity("Walks.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("FileDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Walks.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                            Code = "NSN",
                            Name = "Nelson",
                            RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                            Code = "AKL",
                            Name = "Auckland",
                            RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("14ceba71-4b51-4777-9b17-46602cf66153"),
                            Code = "BOP",
                            Name = "Bay Of Plenty"
                        },
                        new
                        {
                            Id = new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                            Code = "NTL",
                            Name = "Northland"
                        },
                        new
                        {
                            Id = new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                            Code = "STL",
                            Name = "Southland"
                        },
                        new
                        {
                            Id = new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                            Code = "WGN",
                            Name = "Wellington",
                            RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        });
                });

            modelBuilder.Entity("Walks.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("TEXT");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("327aa9f7-26f7-4ddb-8047-97464374bb63"),
                            Description = "This scenic walk takes you around the top of Mount Victoria, offering stunning views of Wellington and its harbor.",
                            DifficultyId = new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                            LengthInKm = 3.5,
                            Name = "Mount Victoria Loop",
                            RegionId = new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                            WalkImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("b4c2f4c5-948d-4f35-b8c7-3f116ed762f1"),
                            Description = "Experience the diverse landscapes of the Tongariro National Park, from alpine meadows to volcanic craters.",
                            DifficultyId = new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                            LengthInKm = 19.399999999999999,
                            Name = "Tongariro Alpine Crossing",
                            RegionId = new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                            WalkImageUrl = "https://images.pexels.com/photos/414171/pexels-photo-414171.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("e9b1f9a1-f9df-4f1a-b830-3a7f564db1a1"),
                            Description = "One of New Zealand's most famous walks, the Milford Track offers stunning scenery in Fiordland National Park.",
                            DifficultyId = new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                            LengthInKm = 53.5,
                            Name = "Milford Track",
                            RegionId = new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                            WalkImageUrl = "https://images.pexels.com/photos/315566/pexels-photo-315566.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("f4316efb-dc14-42e8-94fc-7e6e9b6b2499"),
                            Description = "A circular track through the stunning landscapes of Fiordland National Park, including lakes, forests, and alpine vistas.",
                            DifficultyId = new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                            LengthInKm = 60.0,
                            Name = "Kepler Track",
                            RegionId = new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                            WalkImageUrl = "https://images.pexels.com/photos/1148820/pexels-photo-1148820.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("bc1b4295-1dd4-4d21-9475-8f15eb2d43e4"),
                            Description = "A world-renowned track that passes through beech-forested valleys and alpine gardens.",
                            DifficultyId = new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                            LengthInKm = 32.0,
                            Name = "Routeburn Track",
                            RegionId = new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                            WalkImageUrl = "https://images.pexels.com/photos/417073/pexels-photo-417073.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("14f243bc-42a0-470a-bd37-154b2c53b8b1"),
                            Description = "A coastal walk offering golden beaches and lush, native bush.",
                            DifficultyId = new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                            LengthInKm = 60.0,
                            Name = "Abel Tasman Coast Track",
                            RegionId = new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                            WalkImageUrl = "https://images.pexels.com/photos/12052345/pexels-photo-12052345.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("46e9a1d2-34fa-4a2b-bc02-f53a0e61492f"),
                            Description = "A track that offers diverse landscapes from forested valleys to the rugged west coast.",
                            DifficultyId = new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                            LengthInKm = 78.400000000000006,
                            Name = "Heaphy Track",
                            RegionId = new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                            WalkImageUrl = "https://images.pexels.com/photos/410999/pexels-photo-410999.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("9fc5fbb1-0b58-4d64-bf70-4e0cbff1259c"),
                            Description = "A walk through ancient rainforests and along the shores of the lake.",
                            DifficultyId = new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                            LengthInKm = 46.0,
                            Name = "Lake Waikaremoana Great Walk",
                            RegionId = new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                            WalkImageUrl = "https://images.pexels.com/photos/1230343/pexels-photo-1230343.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("a3d6f7c1-1b4d-4c12-8f2f-9e3e8edc18f1"),
                            Description = "A journey down the Whanganui River by canoe or kayak, including a few short walks.",
                            DifficultyId = new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                            LengthInKm = 145.0,
                            Name = "Whanganui Journey",
                            RegionId = new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                            WalkImageUrl = "https://images.pexels.com/photos/4386375/pexels-photo-4386375.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("b7e7c4c2-8ed4-4d15-bcd8-7957402901f7"),
                            Description = "A journey through the native forest, coastline, and the unique environment of Stewart Island.",
                            DifficultyId = new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                            LengthInKm = 32.0,
                            Name = "Rakiura Track",
                            RegionId = new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                            WalkImageUrl = "https://images.pexels.com/photos/1661214/pexels-photo-1661214.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("73d9e4f1-64b7-4c7f-9620-82952af31f15"),
                            Description = "A trail stretching from Cape Reinga in the north to Bluff in the south, covering a variety of landscapes.",
                            DifficultyId = new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                            LengthInKm = 3000.0,
                            Name = "Te Araroa Trail",
                            RegionId = new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                            WalkImageUrl = "https://images.pexels.com/photos/417074/pexels-photo-417074.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("c2c6bdea-4f1f-40c3-a2a5-5f1b52779b98"),
                            Description = "A track that offers spectacular views of Queen Charlotte Sound.",
                            DifficultyId = new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                            LengthInKm = 70.0,
                            Name = "Queen Charlotte Track",
                            RegionId = new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                            WalkImageUrl = "https://images.pexels.com/photos/1884318/pexels-photo-1884318.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("a54d9f7f-4b8f-4d64-89a7-1f64c0dbf6a5"),
                            Description = "A track offering a unique mix of historic viaducts, lush forest, and sub-alpine terrain.",
                            DifficultyId = new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"),
                            LengthInKm = 61.0,
                            Name = "Hump Ridge Track",
                            RegionId = new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                            WalkImageUrl = "https://images.pexels.com/photos/2906327/pexels-photo-2906327.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("d51e5f8b-758e-45c4-965a-d839f2f2a94c"),
                            Description = "A challenging track leading to the Welcome Flat hot springs.",
                            DifficultyId = new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"),
                            LengthInKm = 17.0,
                            Name = "Copland Track",
                            RegionId = new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                            WalkImageUrl = "https://images.pexels.com/photos/216671/pexels-photo-216671.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        },
                        new
                        {
                            Id = new Guid("3e4b43b2-7d4e-4bbd-9c7a-3b8c0b01b2b1"),
                            Description = "A walk along the rim of an ancient volcano with panoramic views of Christchurch and Lyttelton Harbour.",
                            DifficultyId = new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                            LengthInKm = 16.0,
                            Name = "Crater Rim Walk",
                            RegionId = new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                            WalkImageUrl = "https://images.pexels.com/photos/4413802/pexels-photo-4413802.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                        });
                });

            modelBuilder.Entity("Walks.Models.Domain.Walk", b =>
                {
                    b.HasOne("Walks.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Walks.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}