using MaxiShop_Infrastructure;
using MaxiShop.Domain;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Linq;

namespace MaxiShop.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _dbcontext;


        public CategoryController(ApplicationDbContext dbContext)
        {

            _dbcontext = dbContext;

        }

        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        [HttpPost]

        public ActionResult Create([FromBody] Category category)
        {
            _dbcontext.categories.Add(category);
            _dbcontext.SaveChanges();
            return Ok();


        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]

        [HttpGet]
        [Route ("GetById")]


        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult Get(int id )
        {
            var category =_dbcontext.categories.FirstOrDefault(x => x.Id == id);
            
            

            if (category == null)
            {

                return Ok("PLEASE INPUT CORRECT VALUE");
            }

            return Ok(category);




        }


        [HttpGet]

        public ActionResult get()
        {
            var catergory = _dbcontext.categories.ToList();
            return Ok( catergory);


        }

        [HttpPut]

        public ActionResult Update([FromBody] Category category)
        {
            _dbcontext.categories.Update(category); 
            _dbcontext.SaveChanges();
            return Ok();


        }


        [HttpDelete]

        public ActionResult Delete(int id)
        {

            if (id == 0)
            {

                return BadRequest();

            }


           var category =_dbcontext.categories.FirstOrDefault (x=>x.Id == id);    

            if (id == null)
            {

                return NotFound();

            } 

            _dbcontext.categories.Remove(category);
            _dbcontext.SaveChanges();
            return NoContent();
            
            


        }






    }
}