using Walks.Models.Domain;

namespace Walks.Models.DTO;

public interface IWalkRepository
{
    Task<List<Walk>> GetAllAsync();
    Task<Walk?> GetByIdAsync(Guid id);
    Task<Walk> CreateAsync(Walk walk);
}