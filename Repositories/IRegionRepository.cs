namespace Walks.Repositories;

using Walks.Models.Domain;

public interface IRegionRepository
{
    Task<List<Region>> GetAllAsync();

    Task<Region?> GetByIdAsync(Guid id);
    Task<Region> CreateAsync(Region region);
    Task<Region?> UpdateAsync(Guid id, Region region);
}
// The nullable keyword is used to indicate that a property can be null, because they may not exist in the database.