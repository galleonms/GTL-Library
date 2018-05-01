using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
        Book GetBookById(int id);
        Book GetBookByTitle(string title);
    }
}
