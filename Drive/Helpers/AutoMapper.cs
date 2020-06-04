using AutoMapper;
using Drive.Dtos;
using Drive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drive.Helpers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<DriverForCreationDto, Driver>();
            CreateMap<Driver, DriverToReturnDto>();
        }
    }
}
