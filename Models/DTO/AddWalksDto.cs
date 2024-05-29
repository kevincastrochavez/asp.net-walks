using System.ComponentModel.DataAnnotations;

namespace Walks.Models.DTO;

public class AddWalksDto
{
    [Required]
    [MinLength(1, ErrorMessage = "Name cannot be empty")]
    [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; }
    [Required]
    [MaxLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
    public string Description { get; set; }
    [Required]
    [Range(0, 50, ErrorMessage = "Length must be between 0 and 50 km")]
    public double LengthInKm { get; set; }
    public string? WalkImageUrl { get; set; }
    [Required]
    public Guid DifficultyId { get; set; }
    [Required]
    public Guid RegionId { get; set; }
}