using my_books.Data.Models;
using my_books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class publisherService
    {
        private AppDbContext _context;
        public publisherService(AppDbContext context)
        {
            _context = context;
        }
        public void addPublisher(publisherViewModel publisherViewModel)
        {
            var _publisher = new publisher()
            {
                publisherName = publisherViewModel.publisherName
            };
            _context.publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
