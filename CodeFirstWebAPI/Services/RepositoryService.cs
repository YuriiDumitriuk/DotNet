
using CodeFirstWebAPI.DatabaseContext;
using CodeFirstWebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstWebAPI.Services
{
    public class RepositoryService<T> : IRepositoryService<T>
        where T : class
    {
        private readonly MyDBContext context;
        private readonly DbSet<T> dbSet;
        

        public RepositoryService(MyDBContext context)  
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            
        }

        public void Add(T entity)
        {
            this.dbSet.Add(entity);
            this.context.SaveChanges();
        }


        public void Delete(int id)
        {
            var entity = this.dbSet.Find(id);
            if (entity != null)
            {
                this.dbSet.Remove(entity);
                this.context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll() => this.dbSet.ToList();



        public T GetById(int id) => this.dbSet.Find(id);

        public T GetByName(string name)
        {
            return this.dbSet.First(entity=> EF.Property<string>(entity,"Name")==name);
        }

        
        public void Update(T entity)
        {
            this.dbSet.Update(entity);
            this.context.SaveChanges();
        }

        
    }
}
