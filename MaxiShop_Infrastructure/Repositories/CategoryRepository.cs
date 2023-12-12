using MaxiShop.Domain.Contracts;
using MaxiShop.Domain.Models;
using MaxiShop_Infrastructure.DbContexts;
using MaxiShop_Infrastructure.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop_Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, IcategoryRepository
    {
        public CategoryRepository ( ApplicationDbContext  dbcontext):base(dbcontext) { 
        
        
        
        
        }   
        
        
 

        public async Task UpdateAsync(Category category)
        {
            _dbcontext.Update(category);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
