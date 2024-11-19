using GenericRepoPractice.DataAccessLayer.Context;
using GenericRepoPractise.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepoPractice.DataAccessLayer.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext _appDbContext;
        public DbSet<T> Table { get; set; }


        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            Table = _appDbContext.Set<T>();
        }

        public void Add(T entity)
        {
            Table.Add(entity);      
            //_appDbContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Table.AddRange(entities);
            //_appDbContext.Set<T>().AddRange(entities);
        }

        public T Get(int id)
        {
            return Table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Table.ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Table.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Table.Update(entity);   
        }

    }
}
