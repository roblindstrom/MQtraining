using Microsoft.EntityFrameworkCore;
using MQtraining.Shared.IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MQtraining.Data.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly MQtrainingDbContext _MQtrainingDbContext;
        public BaseRepository(MQtrainingDbContext myDbContext)
        {
            _MQtrainingDbContext = myDbContext;
        }

        //Här körs anroppen mot databasen

        //Väldigt viktigt att i BaseRepository ska endast finnas metoder som flera klasser ska använda sig utav
        //Annars ska man skriva det i den specifika repositorien. Tex ModelRepository

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _MQtrainingDbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _MQtrainingDbContext.Set<T>().ToListAsync();
        }



        public async Task<T> AddAsync(T entity)
        {
            await _MQtrainingDbContext.Set<T>().AddAsync(entity);
            await _MQtrainingDbContext.SaveChangesAsync();

            return entity;
        }


        public async Task DeleteAsync(T entity)
        {
            _MQtrainingDbContext.Set<T>().Remove(entity);
            await _MQtrainingDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _MQtrainingDbContext.Update(entity);
            await _MQtrainingDbContext.SaveChangesAsync();

        }




    }
}
