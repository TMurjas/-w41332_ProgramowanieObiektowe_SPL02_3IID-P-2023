using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.zad3
{
    internal interface IBaseRepository<T,TEntity> where T : IEntity<TEntity>
    {
        void Create(T entity);
        void update(T entity);
        void delete(TEntity id);

        List <T> GetAll();
        T Get(TEntity id);

    }
}
