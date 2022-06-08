using Books.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Entites.Concrete
{
    public class Genre : BaseItem<string>
    {
        [MaxLength(10)]
        [Required(ErrorMessage ="Kod Alani Zorunludur.")]
        public override string Id { get ; set ; }

        [Required(ErrorMessage ="Tur Adi Zorunludur.")]
        [MaxLength(50)]
        public string Name { get; set; }

        public IList<Book> Books { get; set; }
    }
}
