using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly MusicStoreDataContext _context;

        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            _context = new MusicStoreDataContext();
            DbSet = _context.Set<T>();
        }

        public Repository(MusicStoreDataContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}