using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations

namespace PawanBooks.Models
{
    class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CoverType")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
