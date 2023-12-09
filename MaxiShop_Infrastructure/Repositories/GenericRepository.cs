using MaxiShop.Domain;
using MaxiShop.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MaxiShop_Infrastructure;
using MaxiShop.Domain.Contracts;
using MaxiShop_Infrastructure.Repositories;
using MaxiShop_Infrastructure.DbContexts;


namespace MaxiShop_Infrastructure.Repositories
{

    public class GenericRepository<T> : IgenericRepository<T> where T : BaseModel
    {
        protected readonly ApplicationDbContext _dbcontext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;

        }




        public async Task<T> CreateAsync(T entity)
        {

            var AddedEntity = await _dbcontext.Set<T>().AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return AddedEntity.Entity;

        }

        public async Task<T> DeleteAsync(T entity)
        {
            _dbcontext.Remove(entity);
            await _dbcontext.SaveChangesAsync();
            return (entity);


        }

        public async Task<IEnumerable<T>> GetAsync(T entity)
        {
            return await _dbcontext.Set<T>().AsNoTracking().ToListAsync();


        }

        public async Task <T> GetbyIdAsync(Expression<Func<T,bool>> condition )
        {
            return await _dbcontext.Set<T>().AsNoTracking().FirstOrDefaultAsync(condition);
        }

       

   
    }
}




