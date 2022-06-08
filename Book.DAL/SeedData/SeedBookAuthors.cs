using Books.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.SeedData
{
    public class SeedBookAuthors : IEntityTypeConfiguration<BooksAuthors>
    {
        public void Configure(EntityTypeBuilder<BooksAuthors> builder)
        {
            builder.HasData(
              new BooksAuthors { BookId = 1, AuthorId = 18 },
              new BooksAuthors { BookId = 2, AuthorId = 20 },
              new BooksAuthors { BookId = 3, AuthorId = 7 },
              new BooksAuthors { BookId = 4, AuthorId = 2 },
              new BooksAuthors { BookId = 5, AuthorId = 19 },
              new BooksAuthors { BookId = 6, AuthorId = 8 },
              new BooksAuthors { BookId = 7, AuthorId = 12 },
              new BooksAuthors { BookId = 8, AuthorId = 16 },
              new BooksAuthors { BookId = 9, AuthorId = 2 },
              new BooksAuthors { BookId = 10, AuthorId = 20 },
              new BooksAuthors { BookId = 11, AuthorId = 15 },
              new BooksAuthors { BookId = 12, AuthorId = 4 },
              new BooksAuthors { BookId = 13, AuthorId = 21 },
              new BooksAuthors { BookId = 14, AuthorId = 5 },
              new BooksAuthors { BookId = 15, AuthorId = 9 },
              new BooksAuthors { BookId = 16, AuthorId = 13 },
              new BooksAuthors { BookId = 17, AuthorId = 7 },
              new BooksAuthors { BookId = 18, AuthorId = 4 },
              new BooksAuthors { BookId = 19, AuthorId = 11 },
              new BooksAuthors { BookId = 20, AuthorId = 22 },
              new BooksAuthors { BookId = 21, AuthorId = 17 },
              new BooksAuthors { BookId = 22, AuthorId = 3 },
              new BooksAuthors { BookId = 23, AuthorId = 14 },
              new BooksAuthors { BookId = 24, AuthorId = 1 },
              new BooksAuthors { BookId = 25, AuthorId = 10 },
              new BooksAuthors { BookId = 26, AuthorId = 6 },
              new BooksAuthors { BookId = 27, AuthorId = 23 },
              new BooksAuthors { BookId = 28, AuthorId = 4 },
              new BooksAuthors { BookId = 28, AuthorId = 26 },
              new BooksAuthors { BookId = 29, AuthorId = 25 });
        }
    }


}
