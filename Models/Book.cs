using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Librozone.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Librozone.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        [Display(Name = "Page Count")]
        public int PageCount { get; set; }

        [Required]
        [Range(0, 5000, ErrorMessage = "Please enter a price beween 0 and 5000")]
        public double Price { get; set; }

        [Display(Name = "Cover Image URL")]
        public string CoverURL { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public BookCategory BookCategory { get; set; }

        //Relationships

        //Author
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }

        //Publisher
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
    }
}
