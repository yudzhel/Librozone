using System.ComponentModel.DataAnnotations;

namespace Librozone.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Logo")]
        public string LogoURL { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
