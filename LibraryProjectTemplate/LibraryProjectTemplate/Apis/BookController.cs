using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProjectTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryProjectTemplate.Controllers
{
    [Route("api/books")]
    public class BookController : Controller
    {
        // For now, ignore logger
        private readonly IBookRepository _bookRepository;
        ILogger _logger;

        public BookController(IBookRepository bookRepository, ILoggerFactory loggerFactory)
        {
            _bookRepository = bookRepository;
            _logger = loggerFactory.CreateLogger(nameof(BookController));
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            try
            {
                var booksRepo = _bookRepository.Books;
                return new JsonResult(booksRepo);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }
        }

        [HttpGet("{id}", Name = "GetBook")]
        public IActionResult GetBook(int id)
        {
            try
            {
                var booksRepo = _bookRepository.GetBookById(id);
                return new JsonResult(booksRepo);
            }
            catch (Exception exp)
            {
                _logger.LogError(exp.Message);
                return BadRequest();
            }
        }
    }
}
