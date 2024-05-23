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

    // CREATE REGION
    [HttpPost(Name = "CreateRegion")]
    public IActionResult Create([FromBody] AddRegionDto addRegionDto)
    {
        // Create domain model
        var regionModel = new Region
        {
            Code = addRegionDto.Code,
            Name = addRegionDto.Name,
            RegionImageUrl = addRegionDto.RegionImageUrl
        };

        // Add to db
        dbContext.Regions.Add(regionModel);
        dbContext.SaveChanges();

        // Map domain model to DTO
        var regionDTO = new RegionDTO
        {
            Id = regionModel.Id,
            Code = regionModel.Code,
            Name = regionModel.Name,
            RegionImageUrl = regionModel.RegionImageUrl
        };

        // Return DTO
        return CreatedAtAction(nameof(GetById), new { id = regionModel.Id }, regionDTO);
    }

    // UPDATE REGION
    [HttpPut("{id}", Name = "UpdateRegion")]
    public IActionResult Update([FromRoute] Guid id, [FromBody] UpdateRegionDto updateRegionDto)
    {
        // Get region from db
        var regionModel = dbContext.Regions.FirstOrDefault(x => x.Id == id);
        if (regionModel == null)
        {
            return NotFound();
        }

        // Update domain model
        regionModel.Code = updateRegionDto.Code;
        regionModel.Name = updateRegionDto.Name;
        regionModel.RegionImageUrl = updateRegionDto.RegionImageUrl;

        // Save to db
        dbContext.SaveChanges();

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

    // DELETE REGION
    [HttpDelete("{id}", Name = "DeleteRegion")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        // Get region from db
        var regionModel = dbContext.Regions.FirstOrDefault(x => x.Id == id);
        if (regionModel == null)
        {
            return NotFound();
        }

        // Remove from db
        dbContext.Regions.Remove(regionModel);
        dbContext.SaveChanges();

        var regionDTO = new RegionDTO
        {
            Id = regionModel.Id,
            Code = regionModel.Code,
            Name = regionModel.Name,
            RegionImageUrl = regionModel.RegionImageUrl
        };

        // return Ok(regionDTO);
        return NoContent();
    }
}
