using System;
using AutoMapper;
using GineSys.API.Dtos;
using GineSys.API.Models;

namespace GineSys.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<OcupacionToCreateDto,Ocupacion>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Ocupacion,OcupacionToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<OcupacionToUpdateDto, Ocupacion>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.MapFrom(src => src.FechaCreacion);
                })
                .ForMember(dest => dest.UsuarioCreacion, opt => {
                    opt.MapFrom(src => src.UsuarioCreacion);
                })
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
                
            CreateMap<Ocupacion, OcupacionToUpdateDto>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.MapFrom(src => src.FechaCreacion);
                })
                .ForMember(dest => dest.UsuarioCreacion, opt => {
                    opt.MapFrom(src => src.UsuarioCreacion);
                });
        }
    }
}