using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class AuthorsController : ControllerBase
    {
        private authorService _authorsService;
        public AuthorsController(authorService authorService)
        {
            _authorsService = authorService;
        }
        [HttpPost("add-author")]
        public IActionResult addAuthor([FromBody]AuthorViewModel authorViewModel)
        {
            _authorsService.addAuthor(authorViewModel);
            return Ok();
        }
    }
}
