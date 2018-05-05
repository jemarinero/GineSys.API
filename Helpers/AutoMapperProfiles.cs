using AutoMapper;
using GineSys.API.Dtos;
using GineSys.API.Models;

namespace GineSys.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<OcupacionDto,Ocupacion>();
            CreateMap<Ocupacion,OcupacionDto>();
        }
    }
}