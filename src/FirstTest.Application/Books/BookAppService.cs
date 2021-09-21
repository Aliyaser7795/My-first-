using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FirstTest.Books
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        private readonly IBookRepository _BookRepository;
        public virtual async Task<BookDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<Book, BookDto>(await _BookRepository.GetAsync(id));
        }
    }

}
