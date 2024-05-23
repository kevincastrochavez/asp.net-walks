using Microsoft.AspNetCore.Mvc;
using Walks.Models.Domain;

namespace Walks.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionsController : ControllerBase
{
    // GET ALL REGIONS
    [HttpGet(Name = "GetAllRegions")]
    public IActionResult GetAll()
    {
        var regions = new List<Region>
        {
            new Region
            {
                Id = Guid.NewGuid(),
                Code = "AB",
                Name = "Alberta",
                RegionImageUrl = "https://via.placeholder.com/100"
            },
            new Region
            {
                Id = Guid.NewGuid(),
                Code = "BC",
                Name = "British Columbia",
                RegionImageUrl = "https://via.placeholder.com/100"
            },
            new Region
            {
                Id = Guid.NewGuid(),
                Code = "SK",
                Name = "Saskatchewan",
                RegionImageUrl = "https://via.placeholder.com/100"
            }
        };

        return Ok(regions);
    }
}
