using AutoMapper;
using Walks.Models.Domain;
using Walks.Models.DTO;

namespace Walks.Mappings;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Region, RegionDTO>().ReverseMap();

        CreateMap<AddRegionDto, Region>().ReverseMap();

        CreateMap<UpdateRegionDto, Region>().ReverseMap();
        CreateMap<AddWalksDto, Walk>().ReverseMap();

        CreateMap<Walk, WalkDto>().ReverseMap();

        CreateMap<Difficulty, DifficultyDTO>().ReverseMap();
    }
}