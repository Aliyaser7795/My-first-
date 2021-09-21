using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace FirstTest.Books
{
    public interface IBookAppService : IApplicationService
    {

        Task<BookDto> GetAsync(Guid id);

    }
}
