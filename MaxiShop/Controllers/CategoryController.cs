using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Linq;

using MaxiShop_Infrastructure.DbContexts;

using Maxishop.Application.Services.Interface;
using Maxishop.Application.DTO.Category;

namespace MaxiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService  _categoryservice;

        public CategoryController(ICategoryService categoryservice)

        {

            _categoryservice = categoryservice;
        
        }
      

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        [HttpPost]

        public async Task <ActionResult> Create([FromBody] CreateCategoryDto dto)
        {
             
            var addedEntity = await _categoryservice.CreateAsync(dto);
            return Ok();



        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]

        [HttpGet]
        [Route ("GetById")]


        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task  <ActionResult> Get(int id )
        {
            var category = await _categoryservice.GetById(id);
            
            

            if (category == null)
            {

                return Ok("PLEASE INPUT CORRECT VALUE");
            }

            return Ok(category);




        }


        [HttpGet]

        public  async Task <ActionResult> get()
        {
            var categories = await _categoryservice.GetAllAsync();
            return Ok(categories);
            


        }

        [HttpPut]

        public async Task <ActionResult> Update([FromBody] UpdateCategoryDto dto)
        {
              await  _categoryservice.UpdateAsync(dto); 
          
            return NoContent();

        }


        [HttpDelete]

        public  async Task <ActionResult> Delete(int id)
        {

            if (id == 0)
            {

                return BadRequest();

            }


           var category = await _categoryservice.GetById(id);    

            if (category != null)
            {
                await  _categoryservice. DeleteAsync(id);
                return NoContent();
              

            }

            return NotFound();




        }






    }
}