﻿using AloDoutor.Application.DTO;
using AloDoutor.Application.ViewModel;
using AloDoutor.Domain.Entity;
using AutoMapper;

namespace AloDoutor.Application.MappingProfiles
{
    public class EspecialidadeProfile : Profile
    {
        public EspecialidadeProfile()
        {
            //Escrita
            CreateMap<EspecialidadeDTO, Especialidade>();           

            //Leitura
            CreateMap<Especialidade, EspecialidadeViewModel>();

            //Obter todos os medicos de uma especialidade
            CreateMap<Especialidade, EspecialidadeViewModel>()
                .ForMember(dest => dest.Medicos, opt => opt.MapFrom(src => src.EspecialidadeMedicos.Select(m => m.Medico)));
        }
    }
}