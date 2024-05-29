using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Walks.Models.Domain;
using Walks.Models.DTO;

namespace Walks.Controllers;

[ApiController]
[Route("[controller]")]
public class WalksController : ControllerBase
{
    private readonly IMapper mapper;
    private readonly IWalkRepository walkRepository;

    public WalksController(IMapper mapper, IWalkRepository walkRepository)
    {
        this.mapper = mapper;
        this.walkRepository = walkRepository;
    }

    [HttpGet(Name = "GetAllWalks")]
    public async Task<IActionResult> GetAll()
    {
        var walksModel = await walkRepository.GetAllAsync();
        var walksDTO = mapper.Map<List<WalkDto>>(walksModel);

        return Ok(walksDTO);
    }

    [HttpPost(Name = "CreateWalk")]
    public async Task<IActionResult> Create([FromBody] AddWalksDto addWalkDto)
    {
        // Map DTO to domain model
        var walkModel = mapper.Map<Walk>(addWalkDto);
        await walkRepository.CreateAsync(walkModel);

        // Map domain model to DTO
        var walkDTO = mapper.Map<WalkDto>(walkModel);

        return Ok(walkDTO);
    }
}
