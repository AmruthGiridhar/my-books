using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models;
using my_books.Data.Services;
using my_books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public booksService _booksService;
        public BooksController(booksService booksService)
        {
            _booksService = booksService;
        }
        [HttpPost("add-book")]
        public IActionResult addBook([FromBody] bookViewModel book)
        {
            _booksService.addBook(book);
            return Ok();
        }
        [HttpGet("get-all-books")]
        public IActionResult getAllBooks()
        {
            var allBooks = _booksService.getAllBooks();
            return Ok(allBooks);
        }
        [HttpGet("get-book-by-id/{bookId}")]
        public IActionResult getBookById(int bookId)
        {
            var book = _booksService.getAllBookById(bookId);
            return Ok(book);
        }

        [HttpPut("update-book-by-id/{id}")]
        public IActionResult updateBookById(int id,[FromBody]bookViewModel book)
        {
            var updatebook = _booksService.updateBookById(id, book);
            return Ok(updatebook);
        }
        [HttpDelete("delete-book-by-Id/{bookId}")]
        public IActionResult deleteBook(int bookId)
        {
            _booksService.deleteBookById(bookId);
            return Ok();
        }
    }
}
