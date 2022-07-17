namespace GMToolset.Data.Repositories
{
    public interface IRepositoryAsync<T>
    {
        Task<IEnumerable<T>> GetById();

        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> GetByQuery(Func<T> query);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}
