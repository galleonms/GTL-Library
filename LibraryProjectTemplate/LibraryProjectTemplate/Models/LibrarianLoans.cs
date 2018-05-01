using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class LibrarianLoans
    {
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public int LibrarianId { get; set; }
        public Librarian Librarian { get; set; }
    }
}
