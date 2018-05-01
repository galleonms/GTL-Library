using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class Member
    {
        [Key]
        public int SSN { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public bool ActiveMember { get; set; }
        public string Type { get; set; }
        public int NoBooksLoaned { get; set; }
        public int NoofLoans { get; set; }
        [ForeignKey("LibraryCardForeignKey")]
        public LibraryCard LibraryCard { get; set; }
    }
}
