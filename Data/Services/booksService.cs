using my_books.Data.Models;
using my_books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class booksService
    {
          private AppDbContext _context;
           public booksService(AppDbContext context)
        {
            _context = context;
        }
        public void addBook(bookViewModel book)
        {
            var _book = new Book()
            {
                bookTitle = book.bookTitle,
                bookDescription = book.bookTitle,
                isRead = book.isRead,
                dateRead = book.isRead ? book.dateRead.Value : null,
                bookRate = book.bookRate,
                genere = book.genere,
                bookCoverUrl = book.bookCoverUrl,
                bookAuthor = book.bookAuthor,
                bookDateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
    }
}
