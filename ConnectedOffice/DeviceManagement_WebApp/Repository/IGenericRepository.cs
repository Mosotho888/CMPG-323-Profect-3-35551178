using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;

namespace DeviceManagement_WebApp.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(Guid? id);
        T EditByID(Guid? id);
        ConnectedOfficeContext getDb();
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        void deleteById(Guid? id);
        bool Exists(Guid id);

    }

}
