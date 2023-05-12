﻿using System.ComponentModel.DataAnnotations;

namespace Librozone.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
