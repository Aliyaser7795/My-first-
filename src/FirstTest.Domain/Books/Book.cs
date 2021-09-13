using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : AuditedAggregateRoot<Guid>
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
