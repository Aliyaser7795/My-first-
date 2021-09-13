using Acme.BookStore.Books;
using AutoMapper;
using FirstTest.Books;

namespace FirstTest
{
    public class FirstTestApplicationAutoMapperProfile : Profile
    {
        public FirstTestApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateBookDto, Book>();
        }
    }
}
