using Books.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveBoo.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Year { get; set; }
        public string Isbn { get; set; }
        public string Photo { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public List<Genre> Generes { get; set; }
        public List<Author> Authors { get; set; }

    }
}
