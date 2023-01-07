﻿namespace GMToolset.Data.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        bool Exists(Guid id);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Add(T entity);

        void Update(T entity);

        void Delete(Guid id);
    }
}
