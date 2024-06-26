namespace Walks.Repositories;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Walks.Data;
using Walks.Models.Domain;

public class SQLiteRegionRepository : IRegionRepository
{
    private readonly WalksDbContext dbContext;
    public SQLiteRegionRepository(WalksDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<Region> CreateAsync(Region region)
    {
        await dbContext.Regions.AddAsync(region);
        await dbContext.SaveChangesAsync();
        return region;
    }

    public async Task<Region?> DeleteAsync(Guid id)
    {
        var existingRegion = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        if (existingRegion == null)
        {
            return null;
        }

        // Remove from db
        dbContext.Regions.Remove(existingRegion);
        await dbContext.SaveChangesAsync();
        return existingRegion;
    }

    public async Task<List<Region>> GetAllAsync()
    {
        return await dbContext.Regions.ToListAsync();
    }

    public async Task<Region?> GetByIdAsync(Guid id)
    {
        return await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Region?> UpdateAsync(Guid id, Region region)
    {
        var existingRegion = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        if (existingRegion == null)
        {
            return null;
        }

        existingRegion.Code = region.Code;
        existingRegion.Name = region.Name;
        existingRegion.RegionImageUrl = region.RegionImageUrl;

        await dbContext.SaveChangesAsync();
        return existingRegion;
    }
}
