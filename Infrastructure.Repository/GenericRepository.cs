using Domain.Contract.Infrastructure;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq.Expressions;

namespace Infrastucture.Repository
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly ApplicationDbContext _context;
        private readonly Expression<Func<TEntity, bool>> _activeFlagPredicate;
        private readonly DbSet<TEntity> _dbSet;
        private readonly IConfiguration _config;

        public GenericRepository(ApplicationDbContext context, IConfiguration config, Expression<Func<TEntity, bool>> activeFlagPredicate)
        {
            _context = context;
            _activeFlagPredicate = activeFlagPredicate;
            _dbSet = _context.Set<TEntity>();
            _config = config;
        }

        public GenericRepository(ApplicationDbContext context, Expression<Func<TEntity, bool>> activeFlagPredicate)
        {
            _context = context;
            _activeFlagPredicate = activeFlagPredicate;
            _dbSet = _context.Set<TEntity>();
        }


        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }


    }
}
