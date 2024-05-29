using Walks.Models.Domain;

namespace Walks.Models.DTO;

public interface IWalkRepository
{
    Task<Walk> CreateAsync(Walk walk);
}