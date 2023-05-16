using System.ComponentModel.DataAnnotations;

namespace Librozone.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships

        public List<Book> Books { get; set; }
    }
}
