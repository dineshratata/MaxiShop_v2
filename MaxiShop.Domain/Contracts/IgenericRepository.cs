using MaxiShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Domain.Contracts
{
    public interface IgenericRepository<T> where T : BaseModel
    {
        Task<T> CreateAsync(T entity);

        Task<T> DeleteAsync(T entity);

        Task<IEnumerable<T>> GetAsync(T entity);

        Task<T> GetbyIdAsync(Expression<Func<T ,bool>> condition );


    }
}