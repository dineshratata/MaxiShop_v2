using Maxishop.Application.DTO.Category;
using MaxiShop.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Maxishop.Application.Services.Interface
{
    public class CategoryService : ICategoryService
    {
        private readonly IcategoryRepository _icategoryRepository;


        public CategoryService(IcategoryRepository icategoryRepository)
        {


            _icategoryRepository = icategoryRepository;
        }

        public async Task<CategoryDto> CreateAsync(CategoryDto categoryDto)
        {
            await _icategoryRepository.CreateAsync();

        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}