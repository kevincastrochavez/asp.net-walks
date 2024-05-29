using Walks.Data;
using Walks.Mappings;
using Walks.Models.DTO;
using Walks.Repositories;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Walks") ?? "Data Source=Walks.db";

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSqlite<WalksDbContext>(connectionString);
builder.Services.AddScoped<IRegionRepository, SQLiteRegionRepository>();
builder.Services.AddScoped<IWalkRepository, SQLiteWalkRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
