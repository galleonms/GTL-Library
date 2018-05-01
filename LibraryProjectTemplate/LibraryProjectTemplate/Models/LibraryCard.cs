using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class LibraryCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime IssuedDate { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }        
        public string photo { get; set; }
        public int MemberId { get; set; }
    }
}
