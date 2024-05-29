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

    public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
    {
        var existingWalk = await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);
        if (existingWalk == null)
        {
            return null;
        }

        existingWalk.Name = walk.Name;
        existingWalk.Description = walk.Description;
        existingWalk.LengthInKm = walk.LengthInKm;
        existingWalk.WalkImageUrl = walk.WalkImageUrl;
        existingWalk.DifficultyId = walk.DifficultyId;
        existingWalk.RegionId = walk.RegionId;
        await dbContext.SaveChangesAsync();

        return existingWalk;
    }

    public async Task<Walk?> DeleteAsync(Guid id)
    {
        var existingWalk = await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);
        if (existingWalk == null)
        {
            return null;
        }

        // Remove from db
        dbContext.Walks.Remove(existingWalk);
        await dbContext.SaveChangesAsync();

        return existingWalk;
    }
}