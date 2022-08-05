using MAPPING.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DATA_ACCESS.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync(int page = 0, int take = 0);
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> whereCondition = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", int page = 0, int take = 0);
        Task<bool> CreateAsync(T entity);
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<T>> GetAsync(int page = 0, int take = 0)
        {
            var result = await _unitOfWork._context.Set<T>().GetPagedAsync(page, take);

            return result;
        }
        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> whereCondition = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", int page = 0, int take = 10)
        {
            IQueryable<T> query = _unitOfWork._context.Set<T>();

            if (whereCondition != null)
            {
                query = query.Where(whereCondition);

                await query.GetPagedAsync(page, take);
            }
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        public async Task<bool> CreateAsync(T entity)
        {
            try
            {
                await _unitOfWork._context.Set<T>().AddAsync(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
