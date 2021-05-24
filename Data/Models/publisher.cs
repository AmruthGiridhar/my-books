using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Models
{
    public class publisher
    {
        public int publisherId { get; set; }
        public string publisherName { get; set; }

        //navigation properties
        public  List<Book> books { get; set; }
    }
}
