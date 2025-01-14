﻿using System.Linq.Expressions;

namespace app_grades.Repository
{
   
        public interface IRepository<TEntity> where TEntity : class
        {
            TEntity GetById(int id);

            IEnumerable<TEntity> GetAll();
            IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> entity);
            bool Add(TEntity entity);
            bool AddRange(IEnumerable<TEntity> entity);
            bool Remove(TEntity entity);
            bool RemoveRange(IEnumerable<TEntity> entity);

        
        }
}
