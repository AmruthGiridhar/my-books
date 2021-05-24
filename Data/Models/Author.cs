using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class Author
    {
        public int authorId { get; set; }
        public string authorFullName { get; set; }

        //navigation properties
        public List<book_Author> book_Authors { get; set; }
    }
}
