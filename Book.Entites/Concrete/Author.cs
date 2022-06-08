using Books.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Entites.Concrete
{
    public class Author : BaseItem<int>
    {
        public override int Id { get  ; set ; }

        [Required(ErrorMessage ="Ad Alani Zorunludur.")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad Alani Zorunludur.")]
        [MaxLength(50)]
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName+" "+ LastName;
        }

        public IList<BooksAuthors> BookAuthors { get; set; }

    }
}
