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
        public void addBookwithAuthors(bookViewModel book)
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
                //bookAuthor = book.bookAuthor,
                bookDateAdded = DateTime.Now,
                publisherId=book.publisherId
            };
            _context.Books.Add(_book);
            _context.SaveChanges();

            foreach(var id in book.authorIds)
            {
                var _bookAuthor = new book_Author()
                {
                    bookId = _book.bookId,
                    authorId = id
                };
                _context.books_Authors.Add(_bookAuthor);
                _context.SaveChanges();
            }
        }
        public List<Book> getAllBooks()
        {
            return _context.Books.ToList();
        }
        public bookViewModelName getAllBookById(int bookId)
        {
            var _bookWithNames = _context.Books.Where(c=>c.bookId==bookId).Select(book => new bookViewModelName()
            {

                bookTitle = book.bookTitle,
                bookDescription = book.bookTitle,
                isRead = book.isRead,
                dateRead = book.isRead ? book.dateRead.Value : null,
                bookRate = book.bookRate,
                genere = book.genere,
                bookCoverUrl = book.bookCoverUrl,
                publisherName = book.publisher.publisherName,
                authorNames = book.book_Authors.Select(m => m.author.authorFullName).ToList()
            }).FirstOrDefault();
            return _bookWithNames;
        }
        public Book updateBookById(int bookId,bookViewModel book)
        {
            var _book = _context.Books.FirstOrDefault(m => m.bookId == bookId);
            if(_book !=null)
            {
                _book.bookTitle = book.bookTitle;
                _book.bookDescription = book.bookTitle;
                _book.isRead = book.isRead;
                _book.dateRead = book.isRead ? book.dateRead.Value : null;
                _book.bookRate = book.bookRate;
                _book.genere = book.genere;
                _book.bookCoverUrl = book.bookCoverUrl;
                //_book.bookAuthor = book.bookAuthor;

                _context.SaveChanges();
            }
            return _book;
        }
        public void deleteBookById(int bookId)
        {
            var _book = _context.Books.FirstOrDefault(m => m.bookId == bookId);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            };
        }
    }
}
