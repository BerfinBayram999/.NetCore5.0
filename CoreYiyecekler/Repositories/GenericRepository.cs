﻿using CoreYiyecekler.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public T TGet(int id)
        {
           return context.Set<T>().Find(id);

        }

        public List<T> TList(string paramater)
        {

          return context.Set<T>().Include(paramater).ToList();

        }


        // aldigi kategoriye gore listeleme yapar
        public List<T> List( Expression <Func<T,bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList(); 
        }


    }
}
