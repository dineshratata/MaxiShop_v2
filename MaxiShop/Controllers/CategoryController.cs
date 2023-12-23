using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Linq;

using MaxiShop_Infrastructure.DbContexts;

using Maxishop.Application.Services.Interface;
using Maxishop.Application.DTO.Category;
using MaxiShop.Domain.Contracts;
using MaxiShop.Domain.Models;

namespace MaxiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IcategoryRepository  _categoryrepository;

        public CategoryController(IcategoryRepository categoryrepository)

        {

            _categoryrepository = categoryrepository;

        
        }
      

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        [HttpPost]

        public async Task <ActionResult> Create([FromBody] Category category)
        {
             
            var addedEntity = await _categoryrepository.CreateAsync(category);
            return Ok();



        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]

        [HttpGet]
        [Route ("GetById")]


        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task  <ActionResult> Get(int id )
        {
            var category = await _categoryrepository.GetByIdAsync(x=>x.Id==id);
            
            

            if (category == null)
            {

                return NotFound($"Category not found for id- {id}");
            }

            return Ok(category);




        }


        [HttpGet]

        public  async Task <ActionResult> get()
        {
            var categories = await _categoryrepository.GetAllAsync();
            return Ok(categories);
            


        }

        [HttpPut]

        public async Task <ActionResult> Update([FromBody] Category category)
        {
              await _categoryrepository.UpdateAsync(category); 
          
            return NoContent();

        }


        [HttpDelete]

        public  async Task <ActionResult> Delete(int id)
        {

            if (id == 0)
            {

                return BadRequest();

            }


           var category = await _categoryrepository.GetByIdAsync(x=>x.Id==id);    

            if (category != null)
            {
                await _categoryrepository.DeleteAsync(category);
                return NoContent();
              

            }

            return NotFound();




        }






    }
}