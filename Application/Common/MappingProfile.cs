﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Maxishop.Application.DTO.Category;
using MaxiShop.Domain.Models;

namespace Maxishop.Application.Common
{
    public class MappingProfile : Profile
    {

        public MappingProfile( ) {

            CreateMap<Category,  CreateCategoryDto>().ReverseMap();   
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();   
            CreateMap<Category, CategoryDto>().ReverseMap(); 


            
             
        
        }

    }
}
