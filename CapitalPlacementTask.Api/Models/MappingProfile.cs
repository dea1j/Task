using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CapitalPlacementTask.Api.Models.DTOs;

namespace CapitalPlacementTask.Api.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationForm, ApplicationFormDto>().ReverseMap();
            CreateMap<ApplicationForm, CreateApplicationFormDto>().ReverseMap();
            CreateMap<PersonalInfo, PersonalInfoDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().IncludeAllDerived().ReverseMap();
        }
    }
}