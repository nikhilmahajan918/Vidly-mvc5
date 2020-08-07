using System.Collections.Generic;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;
using System;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }






        // here ,this is the starting of movie class....../
        public int? Id { get; set; }


        [Required(ErrorMessage = "Please Enter the Movie Name")]
        [StringLength(255)]
        [Display(Name = "Movie Name")]
        public String Name{ get; set; }


        [Required]
        [Display(Name = "Genre Type")]
        public byte? GenreId { get; set; }


        [Required]
        [Display(Name = "Releasing Date of Movie")]
        public DateTime? ReleaseDate { get; set; }


        [Required]
        [Range(1, 20)]
        [Display(Name = "Movies In Stock")]
        public byte? NumberInStock { get; set; }



        // here this is the end of movie class..../









        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;                          
        }
    }
}