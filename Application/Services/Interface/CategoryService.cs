using AutoMapper;
using Maxishop.Application.DTO.Category;
using MaxiShop.Domain.Contracts;
using MaxiShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Maxishop.Application.Services.Interface
{
    public class CategoryService : ICategoryService
    {
        private readonly IcategoryRepository _icategoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IcategoryRepository icategoryRepository, IMapper mapper)
        {


            _icategoryRepository = icategoryRepository;
            _mapper = mapper;   

        }

        public async Task<CategoryDto> CreateAsync(CreateCategoryDto createcategoryDto)
        {
            var category = _mapper.Map<Category>(createcategoryDto);

            var addedEntity =await _icategoryRepository.CreateAsync(category);

            var entity = _mapper.Map<CategoryDto>(addedEntity);

            return entity;



        }

        public async Task DeleteAsync(int id)
        {
            var category =await _icategoryRepository.GetByIdAsync(x => x.Id == id);

            await _icategoryRepository.DeleteAsync(category);   



        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
          
            var categories = await _icategoryRepository.GetAllAsync();

              return _mapper.Map<List<CategoryDto>>(categories);
           
        }

        public async Task<CategoryDto> GetById(int id)
        {
            
            var category = await _icategoryRepository.GetByIdAsync(x=>x.Id == id);

            return _mapper.Map<CategoryDto>(category);



        }

        public async Task UpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            var categoryup = _mapper.Map<Category>(updateCategoryDto);

            await _icategoryRepository.UpdateAsync(categoryup);


        }
    }
}