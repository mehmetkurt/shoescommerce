using ShoesCommerce.Core.Abstraction;
using System.Linq.Expressions;

namespace ShoesCommerce.Data.Repositories;
public interface IRepository<TEntity, TType>
     where TEntity : BaseEntity<TType>, new()
     where TType : struct
{
    TEntity GetById(TType id);
    IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);
    TEntity Insert(TEntity entity);
    TEntity Update(TEntity entity);
    bool Delete(TEntity entity);
    bool Delete(TType id);

    IQueryable<TEntity> Table { get; }
}
