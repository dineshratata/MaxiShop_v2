using MaxiShop.Domain.Common;
using MaxiShop.Domain.Contracts;
using MaxiShop_Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop_Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        protected readonly ApplicationDbContext _dbcontext;
        
        public GenericRepository(ApplicationDbContext dbcontext)
        {

            _dbcontext = dbcontext;

        }    

        public async Task<T> CreateAsync(T entity)
        {
            var AddedEntity = await _dbcontext.Set<T>().AddAsync(entity);
             await _dbcontext.SaveChangesAsync();
            return AddedEntity.Entity;
              

        }

        public async Task DeleteAsync(T entity)
        {
            _dbcontext.Remove(entity);
            await _dbcontext.SaveChangesAsync();
            

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
         return  await _dbcontext.Set<T>().AsNoTracking().ToListAsync( );
        }

        public async Task<T> GetByIdAsync(Expression<Func<T,bool>> condition)
        {
            return await _dbcontext.Set<T>().AsNoTracking().FirstOrDefaultAsync(condition);

        }
    }
}
