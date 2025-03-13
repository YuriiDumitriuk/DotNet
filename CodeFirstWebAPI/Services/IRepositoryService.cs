﻿namespace CodeFirstWebAPI.Services
{
    public interface IRepositoryService<T> 
        where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T GetByName(string name);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
