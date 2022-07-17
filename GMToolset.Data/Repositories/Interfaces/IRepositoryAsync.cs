namespace GMToolset.Data.Repositories.Interfaces
{
    public interface IRepositoryAsync<T>
    {
        Task<T> GetById(Guid id);

        Task<IEnumerable<T>> GetAll();

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(Guid id);
    }
}
