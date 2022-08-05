using ENTITIES;
using System;

namespace DATA_ACCESS.Generic
{
    public interface IUnitOfWork : IDisposable
    {
        DBContext _context { get; }
        void Commit();
    }
    public class UnitOfWork : IUnitOfWork
    {
        public DBContext _context { get; }
        public UnitOfWork(DBContext context)
        {
            _context = context;
        }    
        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
