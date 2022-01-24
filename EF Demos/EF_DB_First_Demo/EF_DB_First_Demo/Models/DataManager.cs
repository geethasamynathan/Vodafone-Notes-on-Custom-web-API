using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_DB_First_Demo.Models
{
    public class DataManager<T> : IDataRepository<T> where T:class
    {
        public BookStoreContext _context = null;
        public DbSet<T> table = null;
        //readonly BookStoreContext _bookStoreContext=new BookStoreContext();
        public DataManager()
        {
            _context = new BookStoreContext();
            table = _context.Set<T>();
        }

        public void Add(T entity)
        {
            table.Add(entity);
        }

        //public void Delete(Author entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Author Get(long id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Author> GetAll()
        //{
        //    return _bookStoreContext.Authors
        //        .Include(author => author.AuthorContact)
        //.ToList();
        //}

        //public Author GetDto(long id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Author entityToUpdate, Author entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(T entityToUpdate, T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //T IDataRepository<T>.Get(long id)
        //{
        //    throw new NotImplementedException();
        //}

        IEnumerable<T> IDataRepository<T>.GetAll()
        {
            return table.ToList();
        }
    }
}
