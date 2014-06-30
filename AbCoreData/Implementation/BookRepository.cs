using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbCoreData.Implementation
{
    public class BookRepository: IBookRepository, IDisposable
    {
        AbDomainEntities entities = new AbDomainEntities();

        public BookRepository()
        {
            entities = new AbDomainEntities();
        }

        public List<Book> GetList()
        {
            return entities.Books.ToList();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                entities = null;
            }
        }

        ~BookRepository()
        {
            Dispose(false);
        }
    }
}
