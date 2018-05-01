using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class LoanMembers
    {
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }        
    }
}
