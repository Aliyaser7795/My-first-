using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FirstTest.Books
{
   public interface IBookRepository : IRepository<Book, Guid>

    {
    }
}
