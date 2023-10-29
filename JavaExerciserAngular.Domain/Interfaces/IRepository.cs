namespace JavaExerciserAngular.Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : IEntity
{
    public IQueryable<TEntity> GetAll();

    public IQueryable<TEntity> GetByID(int id);

    public TEntity Update(TEntity entity);
}