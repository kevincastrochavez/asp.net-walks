using Microsoft.EntityFrameworkCore;
using Walks.Data;
using Walks.Models.Domain;

namespace Walks.Models.DTO;

public class SQLiteWalkRepository : IWalkRepository
{
    private readonly WalksDbContext dbContext;
    public SQLiteWalkRepository(WalksDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<Walk>> GetAllAsync()
    {
        // Navitgation properties can have these two syntaxes - Include("Region") or Include(x => x.Region)
        return await dbContext.Walks.Include("Region").Include(x => x.Difficulty).ToListAsync();
    }

    public async Task<Walk?> GetByIdAsync(Guid id)
    {
        return await dbContext.Walks
            .Include(x => x.Region)
            .Include(x => x.Difficulty)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Walk> CreateAsync(Walk walk)
    {
        await dbContext.Walks.AddAsync(walk);
        await dbContext.SaveChangesAsync();
        return walk;
    }

}