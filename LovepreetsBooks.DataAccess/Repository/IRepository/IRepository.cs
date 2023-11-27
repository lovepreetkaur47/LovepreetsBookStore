﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LovepreetsBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); 
        //Retrieve Category from the Database by Id 
       //List of Categories Based on requireMents
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
        );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );
        void Add(T entity); //to Add an entity
        void Remove(int id); //to add an object or category
        void Remove(T entity); //another way to remove an object
        void RemoveRange(IEnumerable<T> entity); //removes a complete range of entities
    }
}
