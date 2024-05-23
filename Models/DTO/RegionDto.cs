namespace Walks.Models.DTO;

public class RegionDTO
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string? RegionImageUrl { get; set; }
}

// WHY DO WE NEED DTOs?
// - DTOs are used to transfer data between layers
// - Separation of concerns
// - Security