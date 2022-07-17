namespace GMToolset.Data.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetById();
        
        IEnumerable<T> GetAll();
        
        IEnumerable<T> GetByQuery(Func<T> query);
        
        void Add(T entity);
        
        void Update(T entity);
        
        void Delete(T entity);
    }
}
