using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.ViewModel
{
    public class bookViewModel
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
            //public string bookAuthor { get; set; }

        public int publisherId { get; set; }
        public List<int> authorIds { get; set; }
    }
    public class bookViewModelName
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
        //public string bookAuthor { get; set; }

        public string publisherName { get; set; }
        public List<string> authorNames { get; set; }
    }
}
