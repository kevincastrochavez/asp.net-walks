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
}
