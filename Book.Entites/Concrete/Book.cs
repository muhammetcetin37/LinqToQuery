using Books.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Entites.Concrete
{
    public class Book : BaseItem<int>
    {
        public override int Id { get; set ; }
        [Required(ErrorMessage ="Kitap Tanimi Zorunludur.")]
        [MaxLength(200)]
        public string Title { get; set; }
        [Range(0.0,100000.0,ErrorMessage ="Fiyat Araligi 0 ile 100000 arasinda olmalidir")]
        public double Price { get; set; }
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
        public IList<BooksAuthors> BooksAuthors { get; set; }
    }
}
