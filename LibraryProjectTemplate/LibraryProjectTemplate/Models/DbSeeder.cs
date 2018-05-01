using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProjectTemplate.Models
{
    public class DbSeeder
    {
        private readonly AppDbContext _appDbContext;

        public DbSeeder(AppDbContext appContext)
        {
            _appDbContext = appContext;
        }

        public void Seed()
        {
            _appDbContext.Database.EnsureCreated();

            if (!_appDbContext.Books.Any())
            {

            }
        }
    }
}
