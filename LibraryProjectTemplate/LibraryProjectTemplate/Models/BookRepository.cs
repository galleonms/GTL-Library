using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> Books
        {
            get
            {
                return _appDbContext.Books.OrderBy(c => c.Title);
            }
        }

        // requires 2 primary keys(isbn+library code)
        public Book GetBookById(int id)
        {
            return _appDbContext.Books.Single(c => c.ISBN == id);
        }

        public Book GetBookByTitle(string title)
        {
            return _appDbContext.Books.Single(c => c.Title == title);
        }
    }
}
