using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Entites.Concrete
{
    public class BooksAuthors
    {
        public int BookId { get; set; }
        //navigation property
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        //navigation property
        public Author Author { get; set; }
    }
}
