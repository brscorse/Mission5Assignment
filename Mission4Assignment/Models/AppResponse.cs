using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class AppResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please enter a valid year.")]
        [Range(1900,2030)]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required(ErrorMessage ="Please Enter a valid rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        [Required(ErrorMessage = "Please enter a valid category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
