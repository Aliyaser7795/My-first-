using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace FirstTest.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {

        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public string Borrowpay { get; set; }

        public float Price { get; set; }
        public bool IsBorrowed { get; set; }
        public DateTime BorrowStartDate { get; set; }

        public DateTime BorrowEndDate { get; set; }

    }
}