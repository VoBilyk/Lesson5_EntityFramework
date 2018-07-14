using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Airport.DAL.Interfaces;

namespace Airport.DAL.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> dbSet;


        public GenericRepository(AirportContext context)
        {
            this.dbSet = context.Set<TEntity>();
        }


        public virtual TEntity Get(Guid id)
        {
            var item = dbSet.Find(id);

            if(item == null)
            {
                throw new ArgumentException($"Can`t find item by id:{id}");
            }

            return item;
        }

        public virtual List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual void Create(TEntity item)
        {
            // TODO
            //var foundedItem = dbSet.Find(item);

            //if (foundedItem != null)
            //{
            //    throw new ArgumentException("Item has alredy exist");
            //}

            dbSet.Add(item);
        }

        public virtual void Update(TEntity item)
        {
            //var foundedItem = db.Find(t => t.Id == item.Id);

            //if (foundedItem == null)
            //{
            //    throw new ArgumentException("Item don`t exists");
            //}

            dbSet.Update(item);
            // TODO
            //db.Remove(foundedItem);
            //db.Add(item);
        }

        public virtual void Delete(Guid id)
        {
            //var ticket = dbSet.Find(id);

            //if (ticket == null)
            //{
            //    throw new ArgumentException("Id don`t exists");
            //}

            var item = dbSet.Find(id);
            dbSet.Remove(item);
        }

        public virtual void Delete()
        {
            foreach (var item in dbSet)
            {
                dbSet.Remove(item);
            }
        }
    }
}
