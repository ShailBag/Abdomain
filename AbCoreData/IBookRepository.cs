using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbCoreData
{
    public interface IBookRepository
    {
        List<Book> GetList();

    }
}
