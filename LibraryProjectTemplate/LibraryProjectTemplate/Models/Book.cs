using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }
        [Required]
        public int LibraryCode { get; set; }
        [Required]
        public string Title { get; set; }
        public int Edition { get; set; }
        public int Year { get; set; }
        public int NoPages { get; set; }
        [Required]
        public string Genre { get; set; }
        public bool OnLoan { get; set; }
        public int Stock { get; set; }
        public int CopiesAvailable { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool CanBeLoaned { get; set; }
        [Required]
        public string Language { get; set; }
        public string Binding { get; set; }
    }
}
