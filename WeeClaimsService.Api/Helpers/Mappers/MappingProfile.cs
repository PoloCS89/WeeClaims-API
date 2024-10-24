using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeeClaimsService.Api.Models;

namespace WeeClaimsService.Api.Helpers.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CompaniaViewModel, Compania>();
        }
    }
}