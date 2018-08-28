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

            //Grupos Sanguineos
            CreateMap<GrupoSanguineoToCreateDto,GrupoSanguineo>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<GrupoSanguineo,GrupoSanguineoToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<GrupoSanguineoToUpdateDto, GrupoSanguineo>()
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<GrupoSanguineo, GrupoSanguineoToUpdateDto>();

            //Pacientes
            CreateMap<PacienteForListDto,Paciente>();
            CreateMap<Paciente,PacienteForListDto>()
            .ForMember(dest => dest.Edad, opt => {
                    opt.ResolveUsing(d => d.FechaNacimiento.CalculateAge());
                });
            CreateMap<PacienteForDetailDto,Paciente>();
            CreateMap<Paciente,PacienteForDetailDto>(MemberList.None)
                .ForMember(dest => dest.Edad, opt => {
                    opt.ResolveUsing(d => d.FechaNacimiento.CalculateAge());
                });

             //EnfermedadesAntecedentes
            CreateMap<EnfermedadAntecedenteToCreateDto,EnfermedadAntecedente>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<EnfermedadAntecedente,EnfermedadAntecedenteToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<EnfermedadAntecedenteToUpdateDto, EnfermedadAntecedente>()
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<EnfermedadAntecedente, EnfermedadAntecedenteToUpdateDto>();

            //Parentescos
            CreateMap<ParentescoToCreateDto,Parentesco>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Parentesco,ParentescoToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<ParentescoToUpdateDto, Parentesco>()
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Parentesco, ParentescoToUpdateDto>();

            //Vacunas
            CreateMap<VacunaToCreateDto,Vacuna>()
                .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Vacuna,VacunaToCreateDto>()
                 .ForMember(dest => dest.FechaCreacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<VacunaToUpdateDto, Vacuna>()
                .ForMember(dest => dest.FechaModificacion, opt => {
                    opt.ResolveUsing(d => DateTime.Now);
                });
            CreateMap<Vacuna, VacunaToUpdateDto>();
        }
    }
}