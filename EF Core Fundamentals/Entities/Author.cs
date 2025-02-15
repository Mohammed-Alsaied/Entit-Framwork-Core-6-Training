﻿using System.ComponentModel.DataAnnotations;

namespace EFCore.Entities
{
    public class Author
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(150)]
        public string DisplayName { get; set; }

    }
}
