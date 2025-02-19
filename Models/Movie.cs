﻿using System.ComponentModel.DataAnnotations;

namespace JoelMovieCollection.Models
{
    public class Movie
    {
        //set the properties of an individual movie
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required] 
        public string Category { get; set; }
        [Required] 
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }

    }
}
