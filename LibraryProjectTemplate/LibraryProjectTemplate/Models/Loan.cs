using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class Loan
    {
        public Loan()
        {
            LoanBooks = new List<Book>();
        }

        [Key]
        public int Id { get; set; }
        public virtual List<Book> LoanBooks { get; set; }
        [Required]
        public int MemberSSN { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int GracePeriod { get; set; }
    }
}
