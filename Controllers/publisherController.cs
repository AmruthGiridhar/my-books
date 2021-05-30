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
    public class publisherController : ControllerBase
    {
        publisherService _publisherService;
        public publisherController(publisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpPost("add-publisher")]
        public IActionResult addPublisher(publisherViewModel publisherViewModel)
        {
            _publisherService.addPublisher(publisherViewModel);
            return Ok();
        }
    }
}
