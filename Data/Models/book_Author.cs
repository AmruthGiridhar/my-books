using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class book_Author
    {
        [Key]
        public int bookAuthorId { get; set; }

        public int bookId { get; set; }
        public Book book { get; set; }

        public int authorId  { get; set; }
        public Author author { get; set; }
    }
}
