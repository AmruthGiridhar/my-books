using my_books.Data.Models;
using my_books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class authorService
    {
        private AppDbContext _context;
        public authorService(AppDbContext context)
        {
            _context = context;
        }
        public void addAuthor(AuthorViewModel authorViewModel)
        {
            var _author = new Author()
            {
                authorFullName = authorViewModel.authorFullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
