using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FirstTest.Books
{
    public class CreateBookDto
    {



        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public BookType Type { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        [Required]
        public string Borrowpay { get; set; }
        [Required]
        public float Price { get; set; }
        public bool IsBorrowed { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BorrowStartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BorrowEndDate { get; set; }

    }
}
