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
            //ocupacion
            CreateMap<OcupacionToCreateDto,Ocupacion>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Ocupacion,OcupacionToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<OcupacionToUpdateDto, Ocupacion>()
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Ocupacion, OcupacionToUpdateDto>();

            //religion
            CreateMap<ReligionToCreateDto,Religion>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Religion,ReligionToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<ReligionToUpdateDto, Religion>()
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Religion, ReligionToUpdateDto>();

            //Aseguradoras
            CreateMap<AseguradoraToCreateDto,Aseguradora>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Aseguradora,AseguradoraToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<AseguradoraToUpdateDto, Aseguradora>()
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Aseguradora, AseguradoraToUpdateDto>();
        }
    }
}