using _01_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _01_Framework.Infrastructure
{
    public interface Irepository<TKey, T> where T : DomainBase<TKey>
    {

        void Create(T entity);

        List<T> GetAll();

        T Get(TKey id);

        bool Exists(Expression<Func<T, bool>> expression);

    }
}
