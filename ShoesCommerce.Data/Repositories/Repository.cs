using ShoesCommerce.Core.Abstraction;
using System.Linq.Expressions;

namespace ShoesCommerce.Data.Repositories;
public class Repository<TEntity, TType> : IRepository<TEntity, TType>
    where TEntity : BaseEntity<TType>, new()
    where TType : struct
{
    private readonly ShoesCommerceDbContext _dbContext;

    public IQueryable<TEntity> Table => _dbContext.Set<TEntity>().AsQueryable();

    public Repository(ShoesCommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TEntity GetById(TType id)
    {
        return _dbContext.Set<TEntity>().Find(id);
    }

    public IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbContext.Set<TEntity>().Where(predicate).AsEnumerable();
    }

    public TEntity Insert(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        _dbContext.SaveChanges();
        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        _dbContext.SaveChanges();
        return entity;
    }

    public bool Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        var result = _dbContext.SaveChanges();
        return (result > 0);
    }

    public bool Delete(TType id)
    {
        var entity = GetById(id);
        if (entity == null)
            return false;

        return Delete(entity);
    }
}
