using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.zad1.Interface
{
    internal interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(TEntity id);

        List<T> GetAll();
        T Get(TEntity id);

    }
}
