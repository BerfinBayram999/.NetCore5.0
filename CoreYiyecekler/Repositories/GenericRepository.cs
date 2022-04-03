using CoreYiyecekler.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreYiyecekler.Repositories
{
    public class GenericRepository<T> where T:class ,new()
    {
        Context context = new Context();
        public List<T> CategoryList()
        {

            return context.Set<T>().ToList();
        }

        public void AddCategory(T paramater)
        {
            context.Set<T>().Add(paramater);
            context.SaveChanges();

        }

        public void CategoryDelete(T paramater)
        {

            context.Set<T>().Remove(paramater);
            context.SaveChanges();

        }

        public void CategoryUpdate(T paramater)
        {

            context.Set<T>().Update(paramater);
            context.SaveChanges();

        }

        public void GetCategory(int id)
        {
            context.Set<T>().Find(id);

        }

    }
}
