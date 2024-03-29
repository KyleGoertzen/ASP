﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoStore.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public short NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}