using Microsoft.AspNetCore.Mvc;
using Walks.Models.Domain;
using Walks.Models.DTO;
using Walks.Data;

namespace Walks.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionsController : ControllerBase
{
    // Inject the WalksDbContext in the controller to access the database
    private readonly WalksDbContext dbContext;
    public RegionsController(WalksDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    // GET ALL REGIONS
    [HttpGet(Name = "GetAllRegions")]
    public IActionResult GetAll()
    {
        // Get data from db
        var regionsModel = dbContext.Regions.ToList();

        // Map domain models to DTOs
        var regionsDTO = new List<RegionDTO>();
        foreach (var regionModel in regionsModel)
        {
            regionsDTO.Add(new RegionDTO
            {
                Id = regionModel.Id,
                Code = regionModel.Code,
                Name = regionModel.Name,
                RegionImageUrl = regionModel.RegionImageUrl
            });
        }

        // Return DTOs

        return Ok(regionsDTO);
    }

    // GET REGION BY ID
    [HttpGet("{id}", Name = "GetRegion")]
    public IActionResult GetById(Guid id)
    {
        // var region = dbContext.Regions.Find(id); // Yo can only use the id as parameter
        var regionModel = dbContext.Regions.FirstOrDefault(x => x.Id == id); // Better
        if (regionModel == null)
        {
            return NotFound();
        }

        // Map domain model to DTO
        var regionDTO = new RegionDTO
        {
            Id = regionModel.Id,
            Code = regionModel.Code,
            Name = regionModel.Name,
            RegionImageUrl = regionModel.RegionImageUrl
        };

        // Return DTO
        return Ok(regionDTO);
    }
}
