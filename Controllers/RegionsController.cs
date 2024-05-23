using Microsoft.AspNetCore.Mvc;
using Walks.Models.Domain;
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
        var regions = dbContext.Regions.ToList();

        return Ok(regions);
    }

    // GET REGION BY ID
    [HttpGet("{id}", Name = "GetRegion")]
    public IActionResult GetById(Guid id)
    {
        // var region = dbContext.Regions.Find(id); // Yo can only use the id as parameter
        var region = dbContext.Regions.FirstOrDefault(x => x.Id == id); // Better
        if (region == null)
        {
            return NotFound();
        }
        return Ok(region);
    }
}
