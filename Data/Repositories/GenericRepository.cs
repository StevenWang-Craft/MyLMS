using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected LMSEntities _context;
        public GenericRepository(LMSEntities context)
        {
            _context = context;
        }

        public DbSet<T> Records
        {
            get { return _context.Set<T>(); }
        }

        public virtual T Add(T record)
        {
            Records.Add(record);
            _context.SaveChanges();
            return record;
        }

        public virtual void Delete(T record)
        {
            Records.Remove(record);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Records;
        }

        public virtual T GetById(int Id)
        {
            return Records.Find(Id);
        }

        public T Update(T record)
        {
            Records.Attach(record);
            _context.Entry(record).State = EntityState.Modified;
            _context.SaveChanges();
            return record;
        }
    }
}
