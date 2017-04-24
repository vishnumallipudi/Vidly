﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;
namespace Vidly.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<customerDto,Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Customer,customerDto >();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<Movie,MovieDto>();
            Mapper.CreateMap<Genre,GenreDto>();
        }
            
    }
}

