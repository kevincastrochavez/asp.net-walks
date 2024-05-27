using AutoMapper;
using Walks.Models.Domain;
using Walks.Models.DTO;

namespace Walks.Mappings;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Region, RegionDTO>().ReverseMap();
    }
}