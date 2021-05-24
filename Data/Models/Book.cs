using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class Book
    {
        public int bookId { get; set; }
        public string bookTitle { get; set; }
        public string bookDescription { get; set; }
        public bool isRead { get; set; }
        public DateTime? dateRead { get; set; }
        public int? bookRate { get; set; }
        public string bookCoverUrl { get; set; }
        public DateTime bookDateAdded { get; set; }
        public string genere { get; set; }
        public string bookAuthor { get; set; }

        //navigation properties
        public  int publisherId { get; set; }
        public publisher publisher { get; set; }
        public List<book_Author> book_Authors { get; set; }

    }
}
