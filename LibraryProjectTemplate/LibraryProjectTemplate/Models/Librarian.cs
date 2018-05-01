using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class Librarian
    {
        public Librarian()
        {
            LibraryCards = new List<LibraryCard>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual List<LibraryCard> LibraryCards { get; set; }
    }
}
