using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter the Movie Name")]
        [StringLength(255)]
        [Display(Name = "Movie Name")]
        public String Name { get; set; }

        
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre Type")]
        public byte GenreId { get; set; }



        [Display(Name = "Date added of Movie")]
        public DateTime DateAdded { get; set; }


        [Display(Name = "Releasing Date of Movie")]
        public DateTime ReleaseDate { get; set; }

        [Range(1,20)]
        [Display(Name = "Movies In Stock")]
        public byte NumberInStock { get; set; }


        public byte NumberAvailable { get; set; }


    }
}