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

    public async Task<List<Region>> GetAllAsync()
    {
        return await dbContext.Regions.ToListAsync();
    }

    public async Task<Region?> GetByIdAsync(Guid id)
    {
        return await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
    }
}
