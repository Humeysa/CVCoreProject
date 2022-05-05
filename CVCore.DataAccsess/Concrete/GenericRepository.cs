using CVCore.DataAccsess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVCore.DataAccsess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Delete(T t)
        {
            using var context = new DataContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var context = new DataContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new DataContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new DataContext();
            context.Add(t);
            context.SaveChanges ();
        }

        public void Update(T t)
        {
            using var context = new DataContext();
            context.Update(t);
            context.SaveChanges() ;
        }
    }
}
