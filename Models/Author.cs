﻿using Librozone.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Librozone.Models
{
    public class Author:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
		[Required(ErrorMessage = "Profile Picture is required!")]
		public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 chars.")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
		[Required(ErrorMessage = "Biography is required!")]
		public string Bio { get; set; }

        //Relationships

        public List<Book>? Books { get; set; }
    }
}
