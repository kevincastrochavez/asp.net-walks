using Walks.Models.Domain;

namespace Walks.Models.DTO;

public interface IWalkRepository
{
    Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool? isAscending = true); // There may be nothing to filter on, or sort by
    Task<Walk?> GetByIdAsync(Guid id);
    Task<Walk> CreateAsync(Walk walk);
    Task<Walk?> UpdateAsync(Guid id, Walk walk);
    Task<Walk?> DeleteAsync(Guid id);
}