namespace GMToolset.Services.Interfaces
{
    public interface IModelService<T>
    {
        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Add(T entity);

        void Update(T entity);

        void Delete(Guid id);
    }
}
