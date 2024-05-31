using Microsoft.AspNetCore.Mvc;
using Walks.Models.Domain;
using Walks.Models.DTO;
using Walks.Data;
using Microsoft.EntityFrameworkCore;
using Walks.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;

namespace Walks.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionsController : ControllerBase
{
    // Inject the WalksDbContext in the controller to access the database
    private readonly WalksDbContext dbContext;
    private readonly IRegionRepository regionRepository;
    private readonly IMapper mapper;
    private readonly ILogger<RegionsController> logger;

    public RegionsController(WalksDbContext dbContext, IRegionRepository regionRepository, IMapper mapper, ILogger<RegionsController> logger)
    {
        this.dbContext = dbContext;
        this.regionRepository = regionRepository;
        this.mapper = mapper;
        this.logger = logger;
    }

    // GET ALL REGIONS
    [HttpGet(Name = "GetAllRegions")]
    // [Authorize(Roles = "Reader")]
    public async Task<IActionResult> GetAll()
    {
        // Logging
        logger.LogInformation("Getting all regions method was called");

        // Get data from db
        var regionsModel = await regionRepository.GetAllAsync();

        // Logging
        logger.LogInformation($"Regions retrieved successfully, with data: {JsonSerializer.Serialize(regionsModel)}");

        // Map domain models to DTOs
        var regionsDTO = mapper.Map<List<RegionDTO>>(regionsModel);

        // Return DTOs
        return Ok(regionsDTO);
    }

    // GET REGION BY ID
    [HttpGet("{id}", Name = "GetRegion")]
    [Authorize(Roles = "Reader")]
    public async Task<IActionResult> GetById(Guid id)
    {
        // var region = dbContext.Regions.Find(id); // Yo can only use the id as parameter
        // var regionModel = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id); // Better
        var regionModel = await regionRepository.GetByIdAsync(id);
        if (regionModel == null)
        {
            return NotFound();
        }

        // Map domain model to DTO
        var regionDTO = mapper.Map<RegionDTO>(regionModel);

        // Return DTO
        return Ok(regionDTO);
    }

    // CREATE REGION
    [HttpPost(Name = "CreateRegion")]
    [Authorize(Roles = "Writer")]
    [ValidateModel] // Custom validation, see CustomActionFilters. Same way as in update method
    public async Task<IActionResult> Create([FromBody] AddRegionDto addRegionDto)
    {
        // Map DTO to domain model
        var regionModel = mapper.Map<Region>(addRegionDto);

        // Add to db
        regionModel = await regionRepository.CreateAsync(regionModel);

        // Map domain model to DTO
        var regionDTO = mapper.Map<RegionDTO>(regionModel);

        // Return DTO
        return CreatedAtAction(nameof(GetById), new { id = regionModel.Id }, regionDTO);
    }

    // UPDATE REGION
    [HttpPut("{id}", Name = "UpdateRegion")]
    [Authorize(Roles = "Writer")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionDto updateRegionDto)
    {
        // Validation using the Data Annotations
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Map DTO to domain model
        var regionModel = mapper.Map<Region>(updateRegionDto);

        // Check if region exists
        regionModel = await regionRepository.UpdateAsync(id, regionModel);
        if (regionModel == null)
        {
            return NotFound();
        }

        // Map domain model to DTO
        var regionDTO = mapper.Map<RegionDTO>(regionModel);

        // Return DTO
        return Ok(regionDTO);
    }

    // DELETE REGION
    [HttpDelete("{id}", Name = "DeleteRegion")]
    [Authorize(Roles = "Writer")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        // Get region from db
        var regionModel = await regionRepository.DeleteAsync(id);
        if (regionModel == null)
        {
            return NotFound();
        }

        // Map domain model to DTO
        var regionDTO = mapper.Map<RegionDTO>(regionModel);

        // return NoContent();
        return Ok(regionDTO);
    }
}
