using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Walks.Migrations
{
    /// <inheritdoc />
    public partial class AddWalksData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("2201c851-ba47-47ea-aadf-bb9b7ac80216"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("45359600-275a-4179-a2d3-c375b7a3dca8"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("8d8e7199-0409-4cea-8d33-6eabdaeb7d50"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1b8e159e-5345-42aa-be45-57dec1ed71bd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8b9399fc-980d-44fd-aafa-e896f9637103"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dc1cae41-d002-4ae6-a829-0065c17ed534"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e7dd40f4-32a8-4e97-978e-281764a355e6"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"), "Easy" },
                    { new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), "Medium" },
                    { new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("14ceba71-4b51-4777-9b17-46602cf66153"), "BOP", "Bay Of Plenty", null },
                    { new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "NTL", "Northland", null },
                    { new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "NSN", "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "STL", "Southland", null },
                    { new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });

            migrationBuilder.InsertData(
                table: "Walks",
                columns: new[] { "Id", "Description", "DifficultyId", "LengthInKm", "Name", "RegionId", "WalkImageUrl" },
                values: new object[,]
                {
                    { new Guid("14f243bc-42a0-470a-bd37-154b2c53b8b1"), "A coastal walk offering golden beaches and lush, native bush.", new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"), 60.0, "Abel Tasman Coast Track", new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "https://images.pexels.com/photos/12052345/pexels-photo-12052345.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("327aa9f7-26f7-4ddb-8047-97464374bb63"), "This scenic walk takes you around the top of Mount Victoria, offering stunning views of Wellington and its harbor.", new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"), 3.5, "Mount Victoria Loop", new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"), "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("3e4b43b2-7d4e-4bbd-9c7a-3b8c0b01b2b1"), "A walk along the rim of an ancient volcano with panoramic views of Christchurch and Lyttelton Harbour.", new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"), 16.0, "Crater Rim Walk", new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "https://images.pexels.com/photos/4413802/pexels-photo-4413802.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("46e9a1d2-34fa-4a2b-bc02-f53a0e61492f"), "A track that offers diverse landscapes from forested valleys to the rugged west coast.", new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"), 78.400000000000006, "Heaphy Track", new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "https://images.pexels.com/photos/410999/pexels-photo-410999.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("73d9e4f1-64b7-4c7f-9620-82952af31f15"), "A trail stretching from Cape Reinga in the north to Bluff in the south, covering a variety of landscapes.", new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"), 3000.0, "Te Araroa Trail", new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "https://images.pexels.com/photos/417074/pexels-photo-417074.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("9fc5fbb1-0b58-4d64-bf70-4e0cbff1259c"), "A walk through ancient rainforests and along the shores of the lake.", new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), 46.0, "Lake Waikaremoana Great Walk", new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "https://images.pexels.com/photos/1230343/pexels-photo-1230343.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("a3d6f7c1-1b4d-4c12-8f2f-9e3e8edc18f1"), "A journey down the Whanganui River by canoe or kayak, including a few short walks.", new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"), 145.0, "Whanganui Journey", new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "https://images.pexels.com/photos/4386375/pexels-photo-4386375.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("a54d9f7f-4b8f-4d64-89a7-1f64c0dbf6a5"), "A track offering a unique mix of historic viaducts, lush forest, and sub-alpine terrain.", new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), 61.0, "Hump Ridge Track", new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "https://images.pexels.com/photos/2906327/pexels-photo-2906327.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("b4c2f4c5-948d-4f35-b8c7-3f116ed762f1"), "Experience the diverse landscapes of the Tongariro National Park, from alpine meadows to volcanic craters.", new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"), 19.399999999999999, "Tongariro Alpine Crossing", new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"), "https://images.pexels.com/photos/414171/pexels-photo-414171.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("b7e7c4c2-8ed4-4d15-bcd8-7957402901f7"), "A journey through the native forest, coastline, and the unique environment of Stewart Island.", new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"), 32.0, "Rakiura Track", new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "https://images.pexels.com/photos/1661214/pexels-photo-1661214.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("bc1b4295-1dd4-4d21-9475-8f15eb2d43e4"), "A world-renowned track that passes through beech-forested valleys and alpine gardens.", new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), 32.0, "Routeburn Track", new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "https://images.pexels.com/photos/417073/pexels-photo-417073.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("c2c6bdea-4f1f-40c3-a2a5-5f1b52779b98"), "A track that offers spectacular views of Queen Charlotte Sound.", new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), 70.0, "Queen Charlotte Track", new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "https://images.pexels.com/photos/1884318/pexels-photo-1884318.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("d51e5f8b-758e-45c4-965a-d839f2f2a94c"), "A challenging track leading to the Welcome Flat hot springs.", new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"), 17.0, "Copland Track", new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"), "https://images.pexels.com/photos/216671/pexels-photo-216671.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("e9b1f9a1-f9df-4f1a-b830-3a7f564db1a1"), "One of New Zealand's most famous walks, the Milford Track offers stunning scenery in Fiordland National Park.", new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), 53.5, "Milford Track", new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "https://images.pexels.com/photos/315566/pexels-photo-315566.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("f4316efb-dc14-42e8-94fc-7e6e9b6b2499"), "A circular track through the stunning landscapes of Fiordland National Park, including lakes, forests, and alpine vistas.", new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"), 60.0, "Kepler Track", new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"), "https://images.pexels.com/photos/1148820/pexels-photo-1148820.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14ceba71-4b51-4777-9b17-46602cf66153"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f7248fc3-2585-4efb-8d1d-1c555f4087f6"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("14f243bc-42a0-470a-bd37-154b2c53b8b1"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("327aa9f7-26f7-4ddb-8047-97464374bb63"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("3e4b43b2-7d4e-4bbd-9c7a-3b8c0b01b2b1"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("46e9a1d2-34fa-4a2b-bc02-f53a0e61492f"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("73d9e4f1-64b7-4c7f-9620-82952af31f15"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("9fc5fbb1-0b58-4d64-bf70-4e0cbff1259c"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("a3d6f7c1-1b4d-4c12-8f2f-9e3e8edc18f1"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("a54d9f7f-4b8f-4d64-89a7-1f64c0dbf6a5"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("b4c2f4c5-948d-4f35-b8c7-3f116ed762f1"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("b7e7c4c2-8ed4-4d15-bcd8-7957402901f7"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("bc1b4295-1dd4-4d21-9475-8f15eb2d43e4"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("c2c6bdea-4f1f-40c3-a2a5-5f1b52779b98"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("d51e5f8b-758e-45c4-965a-d839f2f2a94c"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("e9b1f9a1-f9df-4f1a-b830-3a7f564db1a1"));

            migrationBuilder.DeleteData(
                table: "Walks",
                keyColumn: "Id",
                keyValue: new Guid("f4316efb-dc14-42e8-94fc-7e6e9b6b2499"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("ea294873-7a8c-4c0f-bfa7-a2eb492cbf8c"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f808ddcd-b5e5-4d80-b732-1ca523e48434"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("906cb139-415a-4bbb-a174-1a1faf9fb1f6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f077a22e-4248-4bf6-b564-c7cf4e250263"));

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2201c851-ba47-47ea-aadf-bb9b7ac80216"), "Easy" },
                    { new Guid("45359600-275a-4179-a2d3-c375b7a3dca8"), "Hard" },
                    { new Guid("8d8e7199-0409-4cea-8d33-6eabdaeb7d50"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("1b8e159e-5345-42aa-be45-57dec1ed71bd"), "RIX", "Riga", "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" },
                    { new Guid("8b9399fc-980d-44fd-aafa-e896f9637103"), "LAR", "Larnaca", "https://images.unsplash.com/photo-1515896480369-9c67a87f4ca8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" },
                    { new Guid("dc1cae41-d002-4ae6-a829-0065c17ed534"), "VNO", "Vilnius", "https://images.unsplash.com/photo-1542601904570-411afe2eab2a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" },
                    { new Guid("e7dd40f4-32a8-4e97-978e-281764a355e6"), "KLA", "Klaipeda", "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80" }
                });
        }
    }
}
