using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBook>()
            .HasKey(pc => new { pc.AuthorId, pc.BookISBN});

            modelBuilder.Entity<LibrarianLoans>()
                .HasKey(pc => new { pc.LoanId, pc.LibrarianId });

            modelBuilder.Entity<LoanMembers>()
                .HasKey(pc => new { pc.LoanId, pc.MemberId});

            //modelBuilder.Entity<Member>()
            //    .HasOne(a => a.LibraryCard)
            //    .WithOne(b => b.MemberId)
            //    .HasForeignKey<LibraryCard>(b => b.Id);
        }
    }
}
