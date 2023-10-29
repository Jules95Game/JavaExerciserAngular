namespace JavaExerciserAngular.Domain.Interfaces;

public interface IService<TEntity> where TEntity : IEntity
{
    public List<TEntity> GetAll();

    public List<TEntity> SearchByQuery(string query);

    public TEntity? GetById(int id);

    public TEntity? Update(TEntity entity);
}