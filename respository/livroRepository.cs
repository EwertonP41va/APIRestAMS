using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apidotnet.Context;
using apidotnet.Interface;
using Microsoft.EntityFrameworkCore;

namespace apidotnet.respository
{
    public class livroRepository<T> : livroInterface<T> where T : class
    {
        private readonly DataContext context;

        public livroRepository(DataContext context){
            this.context = context;

        }
         public async Task<IEnumerable<T>> GetAll()
        {
            return await this.context.Set<T>().ToListAsync();
        }
        public void Add(T entity)
        { 
            this.context.Add(entity);
        }

          public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task<bool> Save()
        {
           return (await this.context.SaveChangesAsync()) > 0; 
        }
    }
}