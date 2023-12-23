﻿using Maxishop.Application.DTO.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application.Services.Interface
{
    public interface ICategoryService
    {
        Task <CategoryDto> CreateAsync (CreateCategoryDto createcategoryDto);

        Task DeleteAsync(int id );

        Task  UpdateAsync(UpdateCategoryDto updateCategoryDto );

        Task <IEnumerable<CategoryDto>> GetAllAsync();  
        
        Task<CategoryDto> GetById (int id);




    }
}
