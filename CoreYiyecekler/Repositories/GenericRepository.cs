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
        public List<T> TList()
        {

            return context.Set<T>().ToList();
        }

        public void TAdd(T paramater)
        {
            context.Set<T>().Add(paramater);
            context.SaveChanges();

        }

        public void TDelete(T paramater)
        {

            context.Set<T>().Remove(paramater);
            context.SaveChanges();

        }

        public void TUpdate(T paramater)
        {

            context.Set<T>().Update(paramater);
            context.SaveChanges();

        }

        public void TGet(int id)
        {
            context.Set<T>().Find(id);

        }

    }
}
