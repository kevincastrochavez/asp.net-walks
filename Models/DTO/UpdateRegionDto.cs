using System.ComponentModel.DataAnnotations;

namespace Walks.Models.DTO;

public class UpdateRegionDto
{
    [Required]
    [MinLength(3, ErrorMessage = "Code must be at least 3 characters long")]
    [MaxLength(5, ErrorMessage = "Code must be at most 5 characters long")]
    public string Code { get; set; }
    [Required]
    [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
    [MaxLength(50, ErrorMessage = "Name must be at most 50 characters long")]
    public string Name { get; set; }
    public string? RegionImageUrl { get; set; }
}
