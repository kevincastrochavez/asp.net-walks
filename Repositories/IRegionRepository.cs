namespace Walks.Repositories;

using Walks.Models.Domain;

public interface IRegionRepository
{
    Task<List<Region>> GetAllAsync();
}